using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Timers;

namespace IntegracaoBindingBD
{
    public partial class Navegador : Form
    {
        public int iEtapa = 0;
        public int piSeccionaArq = 0;
        public string psCript1 = "var vAux = document.getElementById(\"tab1\");\r\nvar vAux2 = vAux.getElementsByTagName(\"iframe\");\r\nvar vAux3 = vAux2[0].contentWindow.document;\r\nconsole.log(vAux3);\r\nvar vFormLogin = vAux3.getElementsByName(\"login\");\r\nvFormLogin[0].value = \"pedroanhaia\";\r\nvar vFormPwd = vAux3.getElementsByName(\"pwd\");\r\nvFormPwd[0].value = \"jyMI1234\"; \r\nvar vButtonLogin = vAux3.getElementsByClassName(\"button-link\");\r\nvButtonLogin[1].click();\r\n//console.log(vButtonLogin[1]);\r\n";
        public string psCript2 = "";
        public string psCript3 = "";
        public string psParametro = "";
        public string psLogin = "";
        public string psSenha = "";
        public string psNomeArquivo = "";
        static string psDocumentAnterior = "";
        public bool pbCarregaAut = false;
        //static Microsoft.Web.WebView2.WinForms.WebView2 sWebView;

        public static System.Timers.Timer _timer;
        public Navegador(string sLogin, string sSenha, String sParametro, string sNomeArquivo, bool bCarregaAut, int iSeccionaArq)
        {
            InitializeComponent();
            psParametro = sParametro;
            psLogin = sLogin;
            psSenha = sSenha;
            psNomeArquivo = sNomeArquivo;
            pbCarregaAut = bCarregaAut;
            piSeccionaArq = iSeccionaArq;
            //bool b = executarTarefa(this.webView2).GetAwaiter().GetResult();
            //System.Threading.SynchronizationContext.Current.Post((_) => { executarTarefa(this.webView2); }, null);

        }

        //public async void executarTarefa(Microsoft.Web.WebView2.WinForms.WebView2 sWebView)
        //{
        //    while (true)
        //    {
        //        Thread.Sleep(500);
        //        if (!(sWebView == null)) await RegistraReuniao(sWebView);
        //    }
        //}
        //
        //public async Task RegistraReuniao(Microsoft.Web.WebView2.WinForms.WebView2 sWebView)
        //{
        //    string sDocumentAtual = await sWebView.CoreWebView2.ExecuteScriptAsync("document.documentElement.outerHTML");
        //    if (!(sDocumentAtual.Equals(psDocumentAnterior)))
        //    {
        //        psDocumentAnterior = sDocumentAtual;
        //    }
        //}
        private async void button1_Click(object sender, EventArgs e)
        {
            webView2.CoreWebView2.Navigate("https://www.google.com.br/");
            //String value = await  webView2.CoreWebView2.ExecuteScriptAsync(ScriptrichTextBox.Text);
            //object value = await webView2.CoreWebView2.Res(ScriptrichTextBox.Text);
        }

        private void webView2_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            CaminhoURLTextBox.Text = webView2.Source.ToString();
            if (iEtapa == 0)
            {
                psCript1 = "var vAux = document.getElementById(\"tab1\");\r\nvar vAux2 = vAux.getElementsByTagName(\"iframe\");\r\nvar vAux3 = vAux2[0].contentWindow.document;\r\nconsole.log(vAux3);\r\nvar vFormLogin = vAux3.getElementsByName(\"login\");\r\nvFormLogin[0].value = \""+psLogin+"\";\r\nvar vFormPwd = vAux3.getElementsByName(\"pwd\");\r\nvFormPwd[0].value = \""+psSenha+"\"; \r\nvar vButtonLogin = vAux3.getElementsByClassName(\"button-link\");\r\nvButtonLogin[1].click();\r\n//console.log(vButtonLogin[1]);\r\n";
                object value = webView2.ExecuteScriptAsync(psCript1);
                iEtapa++;
            }
            else if (iEtapa == 1)
            {
                //object value = webView2.ExecuteScriptAsync(sCript2);
            
                webView2.CoreWebView2.Navigate("https://ochem.eu/batchupload30/show.do");
                iEtapa++;
            }
            else if (iEtapa == 2)
            {
                psCript2 = "var vAux = document.getElementById(\"tab1\");\r\nvar vAux2 = vAux.getElementsByTagName(\"iframe\");\r\nvar vAux3 = vAux2[0].contentWindow.document;\r\nconsole.log(vAux3);\r\nvar vFormLogin = vAux3.getElementsByName(\"file\");\r\nvar vFormUpload = vAux3.getElementsByTagName(\"form\");\r\nconsole.log(vFormUpload[0]);\r\nvar blob = new File([\""+psParametro+"\"], '"+psNomeArquivo+".csv', {\r\n        type: 'text/plain',\r\n      lastModified: new Date(),\r\n    });\r\nconsole.log(blob);\r\n\r\ndataTransfer = new DataTransfer();\r\n\r\ndataList = dataTransfer.items;\r\ndataList.add(blob);\r\nconsole.log(dataList);\r\nconsole.log(dataTransfer);\r\nvFormLogin[0].files = dataTransfer.files;\r\n\r\n//te amo mete bala kkk s<3 S2 deixar aqui aaa\r\n\r\nvFormUpload[0].submit();";
                object value = webView2.ExecuteScriptAsync(psCript2);
                iEtapa++;
            }
            else if (iEtapa == 3 && pbCarregaAut)
            {
                //psCript3 = "var vAux = document.getElementById(\"tab1\");\r\nvar vAux2 = vAux.getElementsByTagName(\"iframe\");\r\nvar vAux3 = vAux2[0].contentWindow.document;\r\nconsole.log(vAux3);\r\nvar vFormLogin = vAux3.getElementsByName(\"file\");\r\nvar vFormUpload = vAux3.getElementsByTagName(\"form\");\r\nconsole.log(vFormUpload[0]);\r\nvar blob = new File([\"" + psParametro + "\"], '" + psNomeArquivo + ".csv', {\r\n        type: 'text/plain',\r\n      lastModified: new Date(),\r\n    });\r\nconsole.log(blob);\r\n\r\ndataTransfer = new DataTransfer();\r\n\r\ndataList = dataTransfer.items;\r\ndataList.add(blob);\r\nconsole.log(dataList);\r\nconsole.log(dataTransfer);\r\nvFormLogin[0].files = dataTransfer.files;\r\n\r\n//te amo mete bala kkk s<3 S2 deixar aqui aaa\r\n\r\nvFormUpload[0].submit();";
                psCript3 = "var vAux = document.getElementById(\"tab1\");\r\nvar vAux2 = vAux.getElementsByTagName(\"iframe\");\r\nvar vAux3 = vAux2[0].contentWindow.document;\r\nconsole.log(vAux3);\r\nvar vFormLogin = vAux3.getElementsByName(\"notice\");\r\nconsole.log(vFormLogin[0]);\r\nvAux3 = vFormLogin[0].childNodes;\r\nconsole.log(vAux3[1]);\r\nvAux3[1].click();";
                //object value = webView2.ExecuteScriptAsync(psCript2);
                iEtapa++;
            }
            else if (iEtapa == 4 && pbCarregaAut)
            {
                //psCript3 = "var vAux = document.getElementById(\"tab1\");\r\nvar vAux2 = vAux.getElementsByTagName(\"iframe\");\r\nvar vAux3 = vAux2[0].contentWindow.document;\r\nconsole.log(vAux3);\r\nvar vFormLogin = vAux3.getElementsByName(\"file\");\r\nvar vFormUpload = vAux3.getElementsByTagName(\"form\");\r\nconsole.log(vFormUpload[0]);\r\nvar blob = new File([\"" + psParametro + "\"], '" + psNomeArquivo + ".csv', {\r\n        type: 'text/plain',\r\n      lastModified: new Date(),\r\n    });\r\nconsole.log(blob);\r\n\r\ndataTransfer = new DataTransfer();\r\n\r\ndataList = dataTransfer.items;\r\ndataList.add(blob);\r\nconsole.log(dataList);\r\nconsole.log(dataTransfer);\r\nvFormLogin[0].files = dataTransfer.files;\r\n\r\n//te amo mete bala kkk s<3 S2 deixar aqui aaa\r\n\r\nvFormUpload[0].submit();";
                psCript3 = "var vAux = document.getElementById(\"tab1\");\r\nvar vAux2 = vAux.getElementsByTagName(\"iframe\");\r\n//console.log(vAux2[0]);\r\nvar vAux3 = vAux2[0].contentWindow.document;\r\n//console.log(vAux3);\r\nvar vFormLogin = vAux3.getElementsByTagName(\"form\");\r\n//console.log(vFormLogin[0]);\r\nvAux3 = vFormLogin[0].childNodes;\r\n//console.log(vAux3[3]);\r\nvAux3[3].click();";
                //object value = webView2.ExecuteScriptAsync(psCript2);
                iEtapa++;
            }
            else if (iEtapa == 5 && pbCarregaAut)
            {
                //psCript3 = "var vAux = document.getElementById(\"tab1\");\r\nvar vAux2 = vAux.getElementsByTagName(\"iframe\");\r\nvar vAux3 = vAux2[0].contentWindow.document;\r\nconsole.log(vAux3);\r\nvar vFormLogin = vAux3.getElementsByName(\"file\");\r\nvar vFormUpload = vAux3.getElementsByTagName(\"form\");\r\nconsole.log(vFormUpload[0]);\r\nvar blob = new File([\"" + psParametro + "\"], '" + psNomeArquivo + ".csv', {\r\n        type: 'text/plain',\r\n      lastModified: new Date(),\r\n    });\r\nconsole.log(blob);\r\n\r\ndataTransfer = new DataTransfer();\r\n\r\ndataList = dataTransfer.items;\r\ndataList.add(blob);\r\nconsole.log(dataList);\r\nconsole.log(dataTransfer);\r\nvFormLogin[0].files = dataTransfer.files;\r\n\r\n//te amo mete bala kkk s<3 S2 deixar aqui aaa\r\n\r\nvFormUpload[0].submit();";
                psCript3 = "var vAux = document.getElementById(\"tab1\");\r\nvar vAux2 = vAux.getElementsByTagName(\"iframe\");\r\n//console.log(vAux2[0]);\r\nvar vAux3 = vAux2[0].contentWindow.document;\r\n//console.log(vAux3);\r\nvar vFormLogin = vAux3.getElementsByTagName(\"form\");\r\n//console.log(vFormLogin[0]);\r\nvAux3 = vFormLogin[0].childNodes;\r\n//console.log(vAux3[1]);\r\nvAux3[1].click();";
                //object value = webView2.ExecuteScriptAsync(psCript2);
                iEtapa++;
            }
            else if (iEtapa == 6 && pbCarregaAut)
            {
                this.Close();
            }
        }

        private void IR_Click(object sender, EventArgs e)
        {
            webView2.CoreWebView2.Navigate(CaminhoURLTextBox.Text);
        }

    }

}
