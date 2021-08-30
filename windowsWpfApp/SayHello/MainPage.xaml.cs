using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Numerics;
using NBitcoin;
using System.Threading;
using System.Threading.Tasks;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SayHello
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 

    public static class Globals
    {
        public static string text { get; set; }
        public static bool isCaseSensitive { get; set; }
        public static bool isAnywhere { get; set; }
        public static bool position { get; set; }// true = suffix | false = prefix
        public static int numOfThreads { get; set; }
        public static BigInteger totalGenerated { get; set; }
        public static bool isRunning { get; set; }
        public static decimal startTime { get; set; }
        public static string address { get; set; }
        public static string secret { get; set; }

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
        }
    }

    public sealed partial class MainPage : Page
    {
        Random rand;



        void showAddress(string address, string secret)
        {
            addressIndic.Text = address;
        }


        public MainPage()
        {
            this.InitializeComponent();
            rand = new Random();
            threadCount.Text = Globals.numOfThreads.ToString() + " threads (recommended)";
        }

        private void addThread(object sender, TappedRoutedEventArgs e)
        {
            Globals.numOfThreads = Globals.numOfThreads + 1;
            if (Globals.numOfThreads == Environment.ProcessorCount) {
                threadCount.Text = Globals.numOfThreads.ToString() + " threads (recommended)";
            } 
            else
            {
                threadCount.Text = Globals.numOfThreads.ToString() + " threads";
            }
        }
        private void minusThread(object sender, TappedRoutedEventArgs e)
        {
            Globals.numOfThreads = Globals.numOfThreads - 1;
            if (Globals.numOfThreads == Environment.ProcessorCount)
            {
                threadCount.Text = Globals.numOfThreads.ToString() + " threads (recommended)";
            }
            else
            {
                threadCount.Text = Globals.numOfThreads.ToString() + " threads";
            }
        }

        private void updateExample(object sender, KeyRoutedEventArgs e)
        {
            Random numberGen = new Random();

            string newText = textInput.Text;

            bool isCaseSensitive = (bool)caseSensitive.IsChecked;
            bool isAnywhere = (bool)anywhere.IsChecked;
            bool position = positionSwitch.IsOn;

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
                errorMsg.Opacity = 100;
                GenerateBtn.IsEnabled = false;
            }
            else
            {
                errorMsg.Opacity = 0;
                GenerateBtn.IsEnabled = true;
            }
            if (newText.Length > 34) return;
            exampleText.Text = newText;
            updateStats();
        }

        private void enabledDisabledPositionSwitch(object sender, RoutedEventArgs e)
        {
            if (anywhere.IsChecked == true)
            {
                positionSwitch.IsEnabled = false;
            }
            else
            {
                positionSwitch.IsEnabled = true;
            }
            updateExample(null, null);
        }

        private void updateCaseSensitivity(object sender, RoutedEventArgs e)
        {
            updateExample(null, null); 
        }

        private void togglePrefixSuffix(object sender, RoutedEventArgs e)
        {
            updateExample(null, null);
        }

        private void updateExamplePaste(object sender, TextControlPasteEventArgs e)
        {
            updateExample(null, null);
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

        private void startGeneration(object sender, RoutedEventArgs e)
        {
            Globals.startTime = DateTimeOffset.Now.ToUnixTimeSeconds();
            textInput.IsEnabled = false;
            Globals.totalGenerated = new BigInteger(0);
            int threads = Globals.numOfThreads;
            GenerateBtn.IsEnabled = false;
            stopBtn.IsEnabled = true;
            statusIndic.Text = "Allocating threads";
            Globals.isRunning = true;

            for (int i = 0; i < threads; i++) {
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
                        GenerateBtn.IsEnabled = true;
                        stopBtn.IsEnabled = false;
                        textInput.IsEnabled = true;
                        return;
                    }

                    generatedIndic.Text = Globals.totalGenerated.ToString() + " addresses";
                    decimal percent = decimal.Parse(difficultyIndic.Text);
                    decimal totalGenerated = decimal.Parse(Globals.totalGenerated.ToString());
                    decimal indic = (totalGenerated / percent * 100);
                    if (indic.ToString().Length > 10) probabilityIndicNum.Text = indic.ToString().Substring(0, 9) + "%";
                    else probabilityIndicNum.Text = indic.ToString() + "%";
                    if (totalGenerated / percent * 100 > 100) indic = 100;
                    progressBar.Value = Convert.ToDouble(indic);
                    if ((DateTimeOffset.Now.ToUnixTimeSeconds() - Globals.startTime) != 0) speedIndic.Text = (totalGenerated / ((DateTimeOffset.Now.ToUnixTimeSeconds() - Globals.startTime))).ToString() + " addr/s";
                    await Task.Delay(250);
                }
            }
        }

        public static void GenerationThread()
        {
            string targetText = Globals.text;
            if (Globals.isCaseSensitive == false) targetText = targetText.ToLower();


            while (true) {
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
                    Debug.WriteLine(address);
                    Debug.WriteLine(secretKey);
                    Globals.address = address;
                    Globals.secret = secretKey;
                    Globals.isRunning = false;
                    return;
                }
                else
                {
                    if (Globals.position == false && address.Substring(1).StartsWith(targetText))
                    {
                        Debug.WriteLine(address);
                        Debug.WriteLine(secretKey);
                        Globals.address = address;
                        Globals.secret = secretKey;
                        Globals.isRunning = false;
                        return;
                    }
                    else if (Globals.position == true && address.EndsWith(targetText))
                    {
                        Debug.WriteLine(address);
                        Debug.WriteLine(secretKey);
                        Globals.address = address;
                        Globals.secret = secretKey;
                        Globals.isRunning = false;
                        return;
                    }
        }
    }      
        }

        private void stopThreads(object sender, RoutedEventArgs e)
        {
            textInput.IsEnabled = true;
            GenerateBtn.IsEnabled = true;
            stopBtn.IsEnabled = false;
            statusIndic.Text = "Stopping";
            Globals.isRunning = false;
            statusIndic.Text = "Waiting";
        }
    }
}
