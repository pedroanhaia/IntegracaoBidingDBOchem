using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
using System.Security.Principal;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace IntegracaoBindingBD
{
    //public class ValoresJson
    //{
    //    public string psAffinity = "";
    //    public string psAffinityType = "";
    //    public string psMonomerid = "";
    //    public string psSmiles = "";
    //    public ValoresJson (string sAffinity, string sAffinityType, string sMonomerid, string sSmiles)
    //    {
    //        this.psAffinity = sAffinity;
    //        this.psAffinityType = psAffinityType;
    //        this.psMonomerid = sMonomerid;
    //        this.psSmiles = sSmiles;
    //    }
    //}
    public partial class Integracao : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public int piServico = 0;
        //List<ValoresJson> listaProdutos = new List<ValoresJson>();
        public Integracao()
        {
            InitializeComponent();
            LogintextBox.Text = Properties.Settings.Default.Login;
            SenhatextBox.Text = Properties.Settings.Default.Senha;
            NomeArqtextBox.Text = Properties.Settings.Default.NomeArq;
        }
        private void CarregaGradePorJson(int iService, string sJson)
        {
            string sAux = "";
            string[] row0;
            dynamic jsonResponse = JsonConvert.DeserializeObject(sJson);
            dynamic jsonResponse2;
            if (!ApendaBuscacheckBox.Checked) this.DadosBiding.Rows.Clear();
            if (iService == 0)
            {
                jsonResponse2 = jsonResponse["bdb.getTargetByCompoundResponse"];
                jsonResponse2 = jsonResponse2["bdb.affinities"];

                foreach (JToken token in jsonResponse2.Children())
                {
                    //Carreggar os certos
                    row0 = new string[9] { (string)token["bdb.affinity"], (string)token["bdb.affinity_type"], (string)token["bdb.monomerid"], (string)token["bdb.smiles"], (string)token["bdb.inchi"], (string)token["bdb.inhibitor"], (string)token["bdb.species"], (string)token["bdb.tanimoto"], (string)token["bdb.target"] };
                    this.DadosBiding.Rows.Add(row0);

                }
            }
            if (iService == 2 || iService == 1)
            {
                jsonResponse2 = jsonResponse["bdb.getLigandsByUniprotResponse"];
                jsonResponse2 = jsonResponse2["bdb.affinities"];

                foreach (JToken token in jsonResponse2.Children())
                {
                    row0 = new string[4] {(string)token["bdb.affinity"], (string)token["bdb.affinity_type"], (string)token["bdb.monomerid"], (string)token["bdb.smiles"]};
                    this.DadosBiding.Rows.Add(row0);
                
                }
            }
            //IList<JToken> ChildrenTokens = jsonResponse2.ChildrenTokens;

        }
        private static async Task ProcessRepositories(Integracao form,int iService, string sParam1, string sParam2)
        {
            string sAux = "";
            sParam1 = sParam1.Trim();
            sParam2 = sParam2.Trim();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            form.piServico = iService;
            string sUrlAPI = "http://www.bindingdb.org/axis2/services/BDBService/";
            string sFuncServ = "", sFuncServPos = "";
            if (iService == 0)
            {
                sFuncServ = "getTargetByCompound?smiles=";
                sFuncServPos = "&cutoff=" + sParam2 + "&response=application/json";
            }
            if (iService == 1)
            {
                sFuncServ = "getLigandsByUniprot?uniprot=";
                
                sFuncServPos = ";" + sParam2+ "&response=application/json";
            }
            if (iService == 2)
            {
                sFuncServ = "getLigandsByUniprots?uniprot=";
                sFuncServPos = "&cutoff=" + sParam2+ "&response=application/json";
            }
            sAux = sUrlAPI + sFuncServ + sParam1 + sFuncServPos;
            var stringTask = client.GetStringAsync(sAux);
            var msg = await stringTask;
            form.CarregaGradePorJson(iService, msg);
            //MessageBox.Show(msg);
        }
        static async Task<bool> chamarpelobotao(Integracao form, int iService, string sParam1, string sParam2)
        {
            await ProcessRepositories(form, iService, sParam1, sParam2);
            return true;
        }
        private void buscar_Click(object sender, EventArgs e)
        {
            var repositories =  chamarpelobotao(this, 0, param1ComptextBox.Text, param2ComptextBox.Text);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var repositories = chamarpelobotao(this, 1, param1UnitprottextBox.Text, param2UniprotstextBox.Text);
        }

        private void buscargetLigandsByUniprot_Click(object sender, EventArgs e)
        {
            var repositories = chamarpelobotao(this, 2, param1UnitprottextBox.Text, param2UniprotstextBox.Text);
        }

        private void param2UniprotstextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeletaLinha_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in DadosBiding.SelectedCells)
            {
                if (oneCell.Selected)
                    DadosBiding.Rows.RemoveAt(oneCell.RowIndex);
            }
        }
        public string criaParametro()
        {
            string sValor = "", sAux = "", sAux2 = "";
            DataGridViewCell cell;
            int i;
            if (piServico == 0)
            {
                sAux = "IC50,affinity_type,PUBMEDID,smiles,inchi,inhibitor,species,tanimoto,target" + @"\n";
            }
            if (piServico == 1)
            {
                sAux = "IC50,affinity_type,PUBMEDID,smiles" + @"\n";
            }
            DataGridViewRowCollection rData = this.DadosBiding.Rows;
            foreach (DataGridViewRow row in rData)
            {
                for (i=0; i< row.Cells.Count; i++)
                {
                    cell = row.Cells[i];
                    if (cell.Value != null)
                    {
                        
                        if (i!= 4 && i != 5 && i != 6 && i != 8) sAux2 = cell.Value.ToString();
                        else sAux2 = "";
                        //if (i == 1 || i == 3 || i == 4 || i == 5 || i == 6 || i == 8) sAux2 = '"' + sAux2 + '"';
                            if (sValor == "") sValor = sAux2;
                        else if (i==0) sValor = sValor+sAux2;
                        else sValor = sValor + "," + sAux2;

                    }
                    if (piServico == 1 && i == 3)
                    {
                        i = row.Cells.Count;
                    }
                }
                if (sValor != "") sValor = sValor + @"\n";
            }
            if (sValor == "") return sValor;
            sValor = sAux + sValor;
            return sValor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sPAram = criaParametro();
            if (LogintextBox.Text == "")
            {
                MessageBox.Show("Preencha o campo de login!");
                return;
            }
            if (SenhatextBox.Text == "")
            {
                MessageBox.Show("Preencha o campo da senha!");
                return;
            }
            if (NomeArqtextBox.Text == "")
            {
                MessageBox.Show("Preencha o campo do nome do arquivo!");
                return;
            }
            Properties.Settings.Default.Login = LogintextBox.Text;
            Properties.Settings.Default.Senha = SenhatextBox.Text;
            Properties.Settings.Default.NomeArq = NomeArqtextBox.Text;
            Properties.Settings.Default.Save();
            Navegador navegador = new Navegador(LogintextBox.Text, SenhatextBox.Text, sPAram, NomeArqtextBox.Text, CarregaAutcheckBox.Checked, (int)oSeccionaArqnumericUpDown.Value);
            navegador.Show();
        }
    }
}
