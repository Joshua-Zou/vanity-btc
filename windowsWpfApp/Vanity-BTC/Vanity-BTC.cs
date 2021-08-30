using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Threading;
using NBitcoin;

namespace Vanity_BTC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            threadCount.Value = Environment.ProcessorCount;
        }

        private void threadCount_ValueChanged(object sender, EventArgs e)
        {
            Globals.numOfThreads = threadCount.Value;
        }

        private void updateExample(object sender, EventArgs e)
        {
            Random numberGen = new Random();

            string newText = textInput.Text;

            bool isCaseSensitive = (bool)caseSensitive.Checked;
            bool isAnywhere = (bool)anywhere.Checked;
            bool position = false;

            if (suffix.Checked == true) position = true;

            Globals.text = newText;
            Globals.isCaseSensitive = isCaseSensitive;
            Globals.isAnywhere = isAnywhere;
            Globals.position = position;


            if (isCaseSensitive == false)
            {
                string temptext = "";
                for (int i = 0; i < newText.Length; i++)
                {
                    if (numberGen.Next(0, 10) > 5) temptext = temptext + char.ToUpper(newText[i]);
                    else temptext = temptext + char.ToLower(newText[i]);
                }
                newText = temptext;
            }
            string orginialtext = newText;
            if (isAnywhere == true)
            {
                newText = newText.Substring(0, newText.Length);
                string beginningText = "34xp4vRoCGJym3xR7yCVPFHoCNxv4Twseo".Substring(0, 5);
                string endingText = "34xp4vRoCGJym3xR7yCVPFHoCNxv4Twseo".Substring(newText.Length + 5);
                newText = beginningText + orginialtext + endingText;
            }
            else
            {
                if (position == true)
                {
                    if (34 - newText.Length < 0)
                    {
                        textInput.Text = textInput.Text.Substring(1);
                        return;
                    }
                    string temptextx = "34xp4vRoCGJym3xR7yCVPFHoCNxv4Twseo".Substring(0, 34 - newText.Length);
                    newText = temptextx + "" + newText + "";
                }
                else if (position == false)
                {
                    if (newText.Length > "4xp4vRoCGJym3xR7yCVPFHoCNxv4Twseo".Length)
                    {
                        textInput.Text = textInput.Text.Substring(1);
                        return;
                    }
                    string temptexty = "4xp4vRoCGJym3xR7yCVPFHoCNxv4Twseo".Substring((newText.Length));
                    newText = "3" + newText + "" + temptexty;
                }
            }
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");

            if (!regexItem.IsMatch(newText) || newText.Contains(" "))
            {
                errorMsg.Visible = true;
                GenerateBtn.Enabled = false;
            }
            else
            {
                errorMsg.Visible = false;
                GenerateBtn.Enabled = true;
            }
            if (newText.Length > 34) return;
            exampleText.Text = newText;
            updateStats();
        }
        
        private void updateStats()
        {
            string text = Globals.text;
            if (Globals.isCaseSensitive == true)
            {
                //var diff = 1n;
                BigInteger diff = new BigInteger(1);
                BigInteger perc = new BigInteger(1);

                for (var i = 0; i < text.Length; i++)
                {
                    perc = perc * (new BigInteger(62));
                    if (char.IsLetter(text[i]) == true)
                    {
                        // its a letter
                        diff = diff * (new BigInteger(52));
                    }
                    else
                    {
                        // its a number
                        diff = diff * (new BigInteger(10));
                    }
                }
                difficultyIndic.Text = perc.ToString();
                ProbabilityIndic.Text = diff.ToString();
                return;
            }
            if (Globals.isCaseSensitive == false)
            {
                BigInteger diff = new BigInteger(1);
                BigInteger perc = new BigInteger(1);
                for (var i = 0; i < text.Length; i++)
                {
                    perc = perc * (new BigInteger(36));
                    if (char.IsLetter(text[i]) == true)
                    {
                        // its a letter
                        diff = diff * (new BigInteger(26));
                    }
                    else
                    {
                        // its a number
                        diff = diff * (new BigInteger(10));
                    }
                }
                difficultyIndic.Text = perc.ToString();
                ProbabilityIndic.Text = diff.ToString();
                return;
            }
        }

        private void startGeneration(object sender, EventArgs e)
        {
            Globals.shownAlert = false;
            Globals.startTime = DateTimeOffset.Now.ToUnixTimeSeconds();
            textInput.Enabled = false;
            Globals.totalGenerated = new BigInteger(0);
            int threads = Convert.ToInt32(Globals.numOfThreads);
            GenerateBtn.Enabled = false;
            stopBtn.Enabled = true;
            statusIndic.Text = "Allocating threads";
            Globals.isRunning = true;

            for (int i = 0; i < threads; i++)
            {
                string threadName = "workerThread" + i.ToString();
                Thread workerThread = new Thread(new ThreadStart(GenerationThread));
                workerThread.Name = threadName;
                workerThread.Start();
            }
            statusIndic.Text = "Running";
            updateStats();
            async Task updateStats()
            {

                while (true)
                {
                    addressIndic.Text = Globals.address;
                    secretIndic.Text = Globals.secret;
                    if (Globals.isRunning == false)
                    {
                        statusIndic.Text = "Waiting";
                        progressBar.Value = 0;
                        GenerateBtn.Enabled = true;
                        stopBtn.Enabled = false;
                        textInput.Enabled = true;
                        return;
                    }

                    generatedIndic.Text = Globals.totalGenerated.ToString() + " addresses";
                    decimal percent = decimal.Parse(difficultyIndic.Text);
                    decimal totalGenerated = decimal.Parse(Globals.totalGenerated.ToString());
                    decimal indic = (totalGenerated / percent * 100);
                    if (indic.ToString().Length > 10) probabilityIndicNum.Text = indic.ToString().Substring(0, 9) + "%";
                    else probabilityIndicNum.Text = indic.ToString() + "%";
                    if (totalGenerated / percent * 100 > 100) indic = 100;
                    progressBar.Value = Convert.ToInt32(indic);
                    if ((DateTimeOffset.Now.ToUnixTimeSeconds() - Globals.startTime) != 0) speedIndic.Text = (totalGenerated / ((DateTimeOffset.Now.ToUnixTimeSeconds() - Globals.startTime))).ToString() + " addr/s";
                    await Task.Delay(250);
                }
            }
        }

        public static void GenerationThread()
        {
            string targetText = Globals.text;
            if (Globals.isCaseSensitive == false) targetText = targetText.ToLower();


            while (true)
            {
                if (Globals.isRunning == false)
                {
                    return;
                }
                Key newBtcWallet = new Key();
                PubKey publicKey = newBtcWallet.PubKey;
                string address = publicKey.GetAddress(ScriptPubKeyType.Legacy, Network.Main).ToString();
                string secretKey = newBtcWallet.GetWif(Network.Main).ToString();

                Globals.totalGenerated++;
                //if (Globals.totalGenerated % 100 == 0) Debug.WriteLine(Globals.totalGenerated);
                if (Globals.isCaseSensitive == true) address = address.ToLower();

                if (Globals.isAnywhere == true && address.Contains(targetText))
                {
                    // found an address!
                    Console.WriteLine(address);
                    Console.WriteLine(secretKey);
                    Globals.address = address;
                    Globals.secret = secretKey;
                    Globals.isRunning = false;
                    if (Globals.shownAlert == false)
                    {
                        Globals.shownAlert = true;
                        MessageBox.Show("found an address!");
                    }

                    return;
                }
                else
                {
                    if (Globals.position == false && address.Substring(1).StartsWith(targetText))
                    {
                        Console.WriteLine(address);
                        Console.WriteLine(secretKey);
                        Globals.address = address;
                        Globals.secret = secretKey;
                        Globals.isRunning = false;
                        if (Globals.shownAlert == false)
                        {
                            Globals.shownAlert = true;
                            MessageBox.Show("found an address!");
                        }
                        return;
                    }
                    else if (Globals.position == true && address.EndsWith(targetText))
                    {
                        Console.WriteLine(address);
                        Console.WriteLine(secretKey);
                        Globals.address = address;
                        Globals.secret = secretKey;
                        Globals.isRunning = false;
                        if (Globals.shownAlert == false)
                        {
                            Globals.shownAlert = true;
                            MessageBox.Show("found an address!");
                        }
                        return;
                    }
                }
            }
        }

        private void stopThreads(object sender, EventArgs e)
        {
            textInput.Enabled = true;
            GenerateBtn.Enabled = true;
            stopBtn.Enabled = false;
            statusIndic.Text = "Stopping";
            Globals.isRunning = false;
            statusIndic.Text = "Waiting";
        }
    }
    public static class Globals
    {
        public static string text { get; set; }
        public static bool isCaseSensitive { get; set; }
        public static bool isAnywhere { get; set; }
        public static bool position { get; set; }// true = suffix | false = prefix
        public static decimal numOfThreads { get; set; }
        public static BigInteger totalGenerated { get; set; }
        public static bool isRunning { get; set; }
        public static decimal startTime { get; set; }
        public static string address { get; set; }
        public static string secret { get; set; }
        public static bool shownAlert { get; set; }
        static Globals()
        {
            text = "";
            isCaseSensitive = false;
            isAnywhere = false;
            position = false;
            numOfThreads = Environment.ProcessorCount;
            totalGenerated = new BigInteger(0);
            isRunning = false;
            startTime = 1;
            address = "";
            secret = "";
            shownAlert = false;
        }
    }

}
