using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGN
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void timerScanNewTransaction_Tick(object sender, EventArgs e)
        {
            try
            {
                label1.Text = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                richTextBox1.Text = "";

                var nowApi = new Now.NowAPI();
                bool hasNewNowOrder = false;
                Now.NowHistoryStruct nowHistory = nowApi.getNewOrders();
                if (nowHistory != null && nowHistory.Reply != null && nowHistory.Reply.Orders != null)
                {
                    if (nowHistory.Reply.Orders.Length > 0)
                    {
                        hasNewNowOrder = true;
                        richTextBox1.Text += "CÓ ĐƠN NOW \n";
                    }
                }

                var baeminApi = new Baemin.BaeminAPI();
                Baemin.BaeminHistoryStruct baeminHistory = baeminApi.getNewOrders();
                bool hasNewBaeminOrder = false;
                if (baeminHistory != null && baeminHistory.Docs != null)
                {
                    if (baeminHistory.Docs.Length > 0)
                    {
                        foreach (var doc in baeminHistory.Docs)
                        {
                            if (doc.Status == "ASSIGNED")
                            {
                                hasNewBaeminOrder = true;
                                richTextBox1.Text += "CÓ ĐƠN BEAMIN \n";
                            }
                        }
                    }
                }
                

                bool hasNewGrabOrder = false;
                var grabApi = new Grab.GrabAPI();
                Grab.GrabHistoryStruct grabHistory = grabApi.getNewOrders();
                if (grabHistory != null && grabHistory.Orders != null)
                {
                    if (grabHistory.Orders.Length > 0)
                    {
                        hasNewGrabOrder = true;
                        richTextBox1.Text += "CÓ ĐƠN GRAB \n";
                    }
                }
                if (hasNewNowOrder || hasNewBaeminOrder || hasNewGrabOrder)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer("codon.wav");
                    player.Play();
                    Thread.Sleep(2000);
                    player.Play();
                }
            } catch (Exception ee)
            {
                richTextBox1.Text = "Lỗi " + ee.Message;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://gmerchant.deliverynow.vn/api/order/get_processing_orders");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("X-Foody-Api-Version", "1");
            request.AddHeader("X-Foody-Client-Type", "4");
            request.AddHeader("X-Foody-Client-Version", "2.55.1");
            request.AddHeader("X-Foody-Client-Id", "9679242d-ea40-44b2-8534-05a2781688a4");
            request.AddHeader("X-Foody-Device-Id", "ffffffff-a342-944e-ffff-ffffce8b89f9");
            request.AddHeader("X-Foody-App-Type", "1001");
            request.AddHeader("X-Foody-Client-Language", "vi");
            request.AddHeader("X-Foody-Access-Token", "5c5d5192121a22cde8c9ad489e4174592796c5b13299309ae1811246bcc853e570e322669f51750d625be46259b50ef4a6e128a888d554271c34fcfe572e3397");
            request.AddHeader("Content-Type", "application/json; charset=utf-8");
            request.AddHeader("Host", "gmerchant.deliverynow.vn");
            request.AddHeader("Connection", "Keep-Alive");
            request.AddHeader("Accept-Encoding", "gzip");
            client.UserAgent = "okhttp/3.12.1";
            IRestResponse response = client.Execute(request);
            richTextBox1.Text = response.Content;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timerScanNewTransaction.Start();
        }
    }
}
