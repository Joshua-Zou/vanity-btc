<html lang="en_US">

<head>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width,user-scalable=no,initial-scale=1,maximum-scale=1,minimum-scale=1">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Vanity BTC | Bitcoin vanity address generator</title>
    <meta property="og:title" content="Vanity BTC">
    <meta property="og:locale" content="en_US">
    <meta name="description" content="Vanity-BTC is an open source generator using your web browser to generate Bitcoin
    vanity addresses. You can get a custom BTC vanity address right now without the need to install any software!
    After Vanity-BTC generates an address, it will create a wallet compatible with any BTC wallet!">
    <meta property="og:description" content="Vanity-BTC is an open source generator using your web browser to generate Bitcoin
    vanity addresses. You can get a custom BTC vanity address right now without the need to install any software!
    After Vanity-BTC generates an address, it will create a wallet compatible with any BTC wallet!">
    <link rel="canonical" href="https://joshua-zou.github.io/vanity-btc/">
    <meta property="og:url" content="https://joshua-zou.github.io/vanity-btc/">
    <meta property="og:site_name" content="Vanity BTC">
    <meta name="google-site-verification" content="DFWJVWz9IRrh-wjBxn0Y8ith5FTqMeJTSUtuJ595BEs">
    <!--[if IE]><link rel="icon" type="image/x-icon" href="favicon.ico" /><![endif]-->
    <link href="./bundle.js" rel="preload" as="script">
    <link href="./main.css"" rel=" stylesheet">
    <meta name="theme-color" content="#4DBA87">
    <meta name="apple-mobile-web-app-capable" content="no">
    <meta name="apple-mobile-web-app-status-bar-style" content="default">
    <meta name="apple-mobile-web-app-title" content="vanity-btc">
    <meta name="msapplication-TileColor" content="#000000">

</head>

<body data-new-gr-c-s-check-loaded="14.1018.0" data-gr-ext-installed="">
    <div id="app" class="remodal-bg render remodal-is-closed">
        <div id="content" class="container">
            <div data-v-105bd278="">
                <h1 data-v-105bd278="">VANITY-BTC</h1>
                <p data-v-105bd278="">BTC vanity address generator</p>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <div data-v-e4a11f84="" class="panel">
                        <p data-v-e4a11f84=""> Vanity-BTC is an open source tool using your web browser to generate
                            BTC vanity addresses.<br data-v-e4a11f84=""> Enter a short phrase of your
                            liking, and click ‘generate’ to start. </p>
                        <div data-v-e4a11f84="" class="shortcut"><button data-v-e4a11f84="" type="button"
                                class="button-large" onclick="window.scrollTo(0,document.body.scrollHeight);">Start now</button></div>
                        <h2 data-v-e4a11f84="">What's a vanity address?</h2>
                        <p data-v-e4a11f84=""> A vanity address is an address which part of it is chosen by yourself,
                            making it look less random.<br data-v-e4a11f84=""> Examples: <span data-v-e4a11f84=""
                                class="monospace">1hellot661JXGRd7XzvmB7H8nsUZuw24U</span>, or <span
                                data-v-e4a11f84="" class="monospace">1J6XiPDfPSwBBBBBBBU19y8DNTYt86jNaS</span>
                        </p>
                        <h2 data-v-e4a11f84="">How it works</h2>
                        <p data-v-e4a11f84=""> Enter the phrase of your choice, select where you would like to place it, (prefix/suffix/anywhere) and click ‘generate’ to start.
                            Your browser will generate lots of random addresses until one matches your input.<br
                                data-v-e4a11f84=""> Once an address is found, you can reveal the private key.<br data-v-e4a11f84=""> You
                            can increase the number of working threads to reach higher speeds, or decrease it if you
                            device struggles.<br data-v-e4a11f84=""></p>
                        <h2 data-v-e4a11f84="">Security</h2>
                        <p data-v-e4a11f84=""> As explained above, everything is computed only in your browser. Nothing
                            ever leaves your machine, or even your browser tab. There is no database, no server-side
                            code. Everything vanishes when you close your tab.<br data-v-e4a11f84=""><br
                                data-v-e4a11f84=""><b data-v-e4a11f84="">Vanity-BTC cannot and will never store your
                                private key</b>, and if you don't trust it, you have 3 ways to ensure your key remains
                            private:<br data-v-e4a11f84=""> - Once the web page is loaded, you can turn off the internet
                            and continue playing, it will work seamlessly<br data-v-e4a11f84=""> - You can also download
                            the latest build of Vanity-BTC <a data-v-e4a11f84="" href="https://github.com/Joshua-Zou/vanity-btc"
                                target="_blank">here</a> and use it on a completely offline computer<br
                                data-v-e4a11f84=""> - The code is 100% open source and available on <a
                                data-v-e4a11f84="" href="https://github.com/Joshua-Zou/vanity-btc"
                                target="_blank">Github</a>. You can review it as much as you want before using it<br
                                data-v-e4a11f84=""><br data-v-e4a11f84="">
                        <h2 data-v-e4a11f84="">Performance</h2>
                        <p data-v-e4a11f84=""> For some reason, the performance of Vanity-BTC can vary a lot from a
                            browser to another. Currently, Chrome provides the best results.<br data-v-e4a11f84="">
                            Using Vanity-BTC on your phone or tablet will work, but don't expect to reach the speed of a
                            good old (super) computer. </p>
                        <h2 data-v-e4a11f84="">Compatibility</h2>
                        <p data-v-e4a11f84=""> Any address generated with Vanity-BTC is can be used as any normal wallet!
                    </div>
                </div>
            </div>
            <!---->
            <div class="row">
                <div class="col-md-6">
                    <div data-v-9eac7f80="" id="input-panel" class="panel">
                        <form data-v-9eac7f80="" class="">
                            <div data-v-9eac7f80="" class="error-text">Spaces not allowed!</div><input
                                data-v-9eac7f80="" type="text" id="input" placeholder="Text" class="text-input-large">
                            <div data-v-9eac7f80="" class="row justify-content-center hide-render">
                                <div data-v-9eac7f80="" class="spinner">
                                    <div data-v-9eac7f80=""></div>
                                    <div data-v-9eac7f80=""></div>
                                    <div data-v-9eac7f80=""></div>
                                    <div data-v-9eac7f80=""></div>
                                </div>
                            </div>
                            <div data-v-9eac7f80="" class="example hide-prerender"> E.g. <span data-v-9eac7f80=""
                                    class="monospace"> <b data-v-9eac7f80=""></b><span data-v-9eac7f80=""
                                        id="exampleAdr">34xp4vRoCGJym3xR7yCVPFHoCNxv4Twseo</span>
                                    <!---->
                                </span></div>
                            <div data-v-9eac7f80="" class="row controls hide-prerender">
                                <div class="col-12 col-sm-6 col-md-12 col-lg-6"><label data-v-9eac7f80=""
                                        class="checkbox"><input data-v-9eac7f80
                                            onchange="(this.parentElement.children[1].classList.toggle('box-checked')); disable('case-sensitive')"
                                            type="checkbox" name="checkbox" checked="checked" value="not"
                                            id="case-sensitive"><i data-v-9eac7f80="" class="left"></i>
                                        Case-sensitive </label></div>
                                <div class="col-12 col-sm-6 col-md-12 col-lg-6"><label data-v-9eac7f80=""
                                        class="checkbox"><input data-v-9eac7f80
                                            onchange="(this.parentElement.children[1].classList.toggle('box-checked')); disable('prefix/suffix')"
                                            id="prefixsuffixchecked" type="checkbox" name="checkbox" value="checked "
                                            checked="checked"><i data-v-9eac7f80="" class="left"></i>
                                        Anywhere </label></div>
                                <div data-v-9eac7f80="" class="col-12 col-sm-6 col-md-12 col-lg-6" id="prefixsuffixbox">
                                    <span data-v-9eac7f80="">Prefix</span><label data-v-9eac7f80=""
                                        class="switch"><input data-v-9eac7f80="" type="checkbox"
                                            id="sliderCheckbox"><span data-v-9eac7f80="" class="slider"
                                            onclick="changeSliderSettings()"></span></label><span
                                        data-v-9eac7f80="">Suffix</span>
                                </div>
                            </div>
                            <div data-v-9eac7f80="" class="threads hide-prerender"><input data-v-9eac7f80=""
                                    type="button" value="-" class="square-btn button-large"
                                    onclick="minusthread();" id="minusbutton"><input data-v-9eac7f80="" type="button" value="+"
                                    class="square-btn arrow button-large" onclick="addthread()">
                                <h4 data-v-9eac7f80="" id="threads">4</h4><span data-v-9eac7f80=""> threads</span><span
                                    data-v-9eac7f80="" id="recommended">(recommended)</span>
                            </div>
                            <div data-v-9eac7f80="" class="row">
                                <div data-v-9eac7f80="" class="col-lg-6 col-sm-12"><input data-v-9eac7f80=""
                                        type="button" value="Generate" disabled="disabled"
                                        class="button-large hide-render"><input data-v-9eac7f80="" type="button"
                                        value="Generate" class="button-large hide-prerender" id="startButton"></div>
                                <div data-v-9eac7f80="" class="col-lg-6 col-sm-12"><input data-v-9eac7f80=""
                                        type="button" value="Stop" disabled="disabled" id="stopButton" class="button-large"></div>
                            </div>
                        </form>
                    </div>
                </div>
                <div class="col-md-6">
                    <div data-v-3e599529="" class="panel">
                        <div data-v-3e599529="">Difficulty: <span data-v-3e599529="" class="output" id="diffIndic">1</span></div>
                        <div data-v-3e599529="">Generated: <span data-v-3e599529="" class="output"><span id="totalAdrs">0</span> addresses</span>
                        </div>
                        <div data-v-3e599529="">50% probability: <span data-v-3e599529="" class="output"><span id="50perc">10</span> addresses</span></div>
                        <div data-v-3e599529="">Speed: <span data-v-3e599529="" class="output">0 addr/s</span></div>
                        <div data-v-3e599529="">Status: <span data-v-3e599529="" class="output" id="statusIndic">Waiting</span></div>
                        <div data-v-3e599529="" class="probability">
                            <div data-v-3e599529="" class="probability-bar" style="width: 0%;"></div>
                        </div>
                        <div data-v-3e599529="" class="percentage">
                            <h4 data-v-3e599529="" id="probability-indic">0%</h4>
                            <div data-v-3e599529="">Probability</div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <div data-v-e7ef34b6="" class="panel result">
                        <div data-v-e7ef34b6="" class="row">
                            <div data-v-e7ef34b6="" id="identicon" class="float-left"></div>
                            <div data-v-e7ef34b6="" class="col">
                                <div data-v-e7ef34b6="">Address: <span data-v-e7ef34b6="" class="output" id="outputAdr"></span></div>
                                <div data-v-e7ef34b6="">Private key:
                                    <span class="output" data-v-e7ef34b6="" id="outputScr"></span>
                                </div>
                                <div data-v-e7ef34b6="">Extended Public key:
                                    <span class="output" data-v-e7ef34b6="" id="outputXpub"></span>
                                </div>
                            </div>
                        
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <footer data-v-167a421c="">
            <div data-v-167a421c="" class="container">
                <div data-v-167a421c="" class="row">
                    <div data-v-167a421c="" class="col-12 col-lg-6 address"> Tips: <a data-v-167a421c=""
                            href="https://www.blockchain.com/btc/address/38krZgthX9vYqNKiQ9GzY6mpfzEC9W1E26"
                            target="_blank">38krZgthX9vYqNKiQ9GzY6mpfzEC9W1E26</a></div>
                    <div data-v-167a421c="" class="col-12 col-lg-6 links"><a data-v-167a421c=""
                            href="https://www.blockchain.com/btc/address/38krZgthX9vYqNKiQ9GzY6mpfzEC9W1E26"
                            target="_blank"><i data-v-167a421c="" class="icon-bitcoin"></i> Donate </a><a
                            data-v-167a421c="" href="https://github.com/Joshua-Zou/vanity-btc" target="_blank"><i
                                data-v-167a421c="" class="icon-star"></i> Star me </a><a data-v-167a421c=""
                            href="https://github.com/Joshua-Zou/vanity-btc" target="_blank"><i
                                data-v-167a421c="" class="icon-download"></i> Download </a></div>
                </div>
            </div>
        </footer><a data-v-887f6dee="" href="https://github.com/Joshua-Zou/vanity-btc" target="_blank"
            aria-label="View source on Github"><svg data-v-887f6dee="" width="80" height="80" viewBox="0 0 250 250"
                aria-hidden="true"
                style="fill: rgb(21, 21, 19); color: rgb(255, 255, 255); position: absolute; top: 0px; border: 0px; right: 0px;">
                <defs data-v-887f6dee="">
                    <mask data-v-887f6dee="" id="octomask">
                        <path data-v-887f6dee="" fill="white" d="M0,0 L115,115 L130,115 L142,142 L250,250 L250,0 Z">
                        </path>
                        <path data-v-887f6dee="" fill="black"
                            d="M128.3,109.0 C113.8,99.7 119.0,89.6 119.0,89.6 C122.0,82.7 120.5,78.6 120.5,78.6 C119.2,72.0 123.4,76.3 123.4,76.3 C127.3,80.9 125.5,87.3 125.5,87.3 C122.9,97.6 130.6,101.9 134.4,103.2"
                            class="octo-arm" style="transform-origin: 130px 106px;"></path>
                        <path data-v-887f6dee=""
                            d="M115.0,115.0 C114.9,115.1 118.7,116.5 119.8,115.4 L133.7,101.6 C136.9,99.2 139.9,98.4 142.2,98.6 C133.8,88.0 127.5,74.4 143.8,58.0 C148.5,53.4 154.0,51.2 159.7,51.0 C160.3,49.4 163.2,43.6 171.4,40.1 C171.4,40.1 176.1,42.5 178.8,56.2 C183.1,58.6 187.2,61.8 190.9,65.4 C194.5,69.0 197.7,73.2 200.1,77.6 C213.8,80.2 216.3,84.9 216.3,84.9 C212.7,93.1 206.9,96.0 205.4,96.6 C205.1,102.4 203.0,107.8 198.3,112.5 C181.9,128.9 168.3,122.5 157.7,114.1 C157.9,116.9 156.7,120.9 152.7,124.9 L141.0,136.5 C139.8,137.7 141.6,141.9 141.8,141.8 Z"
                            fill="black" class="octo-body"></path>
                    </mask>
                </defs>
                <rect data-v-887f6dee="" fill="white" width="100%" height="100%" mask="url(#octomask)" class="filler">
                </rect>
            </svg></a>
    </div>
    <div class="remodal-overlay remodal-is-closed" style="display: none"></div>
    <div class="remodal-wrapper remodal-is-closed" style="display: none">

    </div>

    <div class="remodal-wrapper remodal-is-closed" style="display: none;">
        <div data-remodal-id="modal" data-remodal-options="hashTracking: false"
            class="remodal remodal-is-initialized remodal-is-closed" tabindex="-1"><button data-remodal-action="close"
                class="remodal-close"></button>
            <h3 class="title">Create encrypted keystore file (UTC / JSON)</h3>
            <form>
                <div><input type="text" autocomplete="username" class="hidden"><input autocomplete="new-password"
                        placeholder="Password" type="password" class="text-input-large"><button type="button"
                        class="show-password"><i class="icon-eye-on"></i></button></div>
                <div><button type="button" disabled="disabled" class="button-large">Download</button></div>
            </form>
        </div>
    </div>
    <div class="remodal-wrapper remodal-is-closed" style="display: none;">
        <div data-remodal-id="modal" data-remodal-options="hashTracking: false"
            class="remodal remodal-is-initialized remodal-is-closed" tabindex="-1">
            <button data-remodal-action="close" class="remodal-close"></button>
            <h3 class="title">Create encrypted keystore file (UTC / JSON)</h3>
            <form>
                <div>
                    <input type="text" autocomplete="username" class="hidden"><input autocomplete="new-password"
                        placeholder="Password" type="password" class="text-input-large"><button type="button"
                        class="show-password"><i class="icon-eye-on"></i></button>
                </div>
                <div><button type="button" disabled="disabled" class="button-large">Download</button></div>
            </form>
        </div>
    </div>
</body>

</html>

<style>
    .box-checked {
        background-color: #f75c1a;
    }
</style>
<script src="./bundle.js"></script>

<script>
    window.vanity_settings = {
        caseSensitive: false,
        anywhere: false,
        mode: "prefix",
        threads: navigator.hardwareConcurrency
    }
    change_background()
    async function change_background() {
        var rotation = 0;
        while (true) {
            rotation++;
            document.body.style.background = `linear-gradient(${rotation}deg, #F7931A, #301af7)`;
            if (rotation === 360) rotation = 0;
            await sleep(50)
        }
    }
    function sleep(ms) {
        return new Promise(resolve => setTimeout(resolve, ms));
    }
    function changeSliderSettings() {
        if (document.getElementById("sliderCheckbox").checked === false) {
            window.vanity_settings.mode = "suffix"
        } else {
            window.vanity_settings.mode = "prefix";
        }
        updateText();
    }
    function disable(element) {
        if (element === "prefix/suffix") {
            if (document.getElementById("prefixsuffixchecked").value === "checked") {
                document.querySelector("#prefixsuffixbox").style = ""
                document.getElementsByClassName("slider")[0].style["background-color"] = "";
                document.getElementById("prefixsuffixchecked").value = "not";
                window.vanity_settings.anywhere = false;
            } else {
                document.querySelector("#prefixsuffixbox").style = "pointer-events:none; background-color: #c3c3c3; padding-left: 10px; color: white;"
                document.getElementsByClassName("slider")[0].style["background-color"] = "grey";
                document.getElementById("prefixsuffixchecked").value = "checked";
                window.vanity_settings.anywhere = true;
            }
        } else if (element === "case-sensitive") {
            if (document.getElementById("case-sensitive").value !== "checked") {
                window.vanity_settings.caseSensitive = true;
                document.getElementById("case-sensitive").value = "checked"
            } else {
                window.vanity_settings.caseSensitive = false;
                document.getElementById("case-sensitive").value = "not"
            }
            updateText();
        }
        updateText();
    }
    document.getElementById("input").addEventListener("keydown", async function (code) {
        await sleep(5)
        if (code.key === " "){
            document.getElementsByClassName("error-text")[0].style.display = "block";
            document.getElementById("startButton").disabled = "disabled";
        }
        if (!document.getElementById("input").value.includes(" ")){
            document.getElementsByClassName("error-text")[0].style = ""
            document.getElementById("startButton").disabled = undefined;
        }
        updateText();
    })
    document.getElementById("threads").innerHTML = window.vanity_settings.threads;
    function addthread() {
        document.getElementById("minusbutton").disabled = undefined;
        if (window.vanity_settings.threads === 64) return;
        window.vanity_settings.threads++;
        document.getElementById("threads").innerHTML = window.vanity_settings.threads;
        document.getElementById("recommended").innerText = "";
        if (window.vanity_settings.threads === navigator.hardwareConcurrency) document.getElementById("recommended").innerText = " (recommended)"
    }
    function minusthread() {
        if (window.vanity_settings.threads === 0) return;
        window.vanity_settings.threads--;
        document.getElementById("threads").innerHTML = window.vanity_settings.threads;
        document.getElementById("recommended").innerText = "";
        if (window.vanity_settings.threads === navigator.hardwareConcurrency) document.getElementById("recommended").innerText = " (recommended)";
        if (window.vanity_settings.threads === 0) document.getElementById("minusbutton").disabled = "disabled";
    }

    async function updateText(){
        await sleep(5)
            let text = document.getElementById("input").value;
        if (window.vanity_settings.caseSensitive === false) {
            let temptext = "";
            for (var i = 0; i < text.length; i++) {
                if (Math.floor(Math.random() * 11) > 5) temptext = temptext + text.charAt(i).toUpperCase();
                else temptext = temptext + text.charAt(i).toLowerCase();
            }
            text = temptext;
        }
        let orginialtext = text;
        if (window.vanity_settings.anywhere === true) {
            text = text.slice(0, text.length);
            beginningText = "34xp4vRoCGJym3xR7yCVPFHoCNxv4Twseo".slice(0,5)
            let endingText = "34xp4vRoCGJym3xR7yCVPFHoCNxv4Twseo".slice(text.length+5);
            text = beginningText+"<u>"+orginialtext+"</u>"+endingText;
        }else{
            if (window.vanity_settings.mode === "suffix"){
                let temptext = "34xp4vRoCGJym3xR7yCVPFHoCNxv4Twseo".slice(0, 34-text.length);
                text = temptext+"<u>"+text+"</u>";
            }else if (window.vanity_settings.mode === "prefix"){
                let temptext = "4xp4vRoCGJym3xR7yCVPFHoCNxv4Twseo".slice((text.length));
                text = "3<u>"+text+"</u>"+temptext
            }
        }
        updateStats();
        document.getElementById("exampleAdr").innerHTML = text;
        }
function updateStats(){
let text = document.getElementById("input").value;
    if (window.vanity_settings.caseSensitive === true){
        var diff = 1n;
        var perc = 1n;
        for (var i = 0; i<text.length; i++){
            perc = perc * 62n;
            if (isNaN(text.charAt(i)) === true){
                // its a letter
                diff = diff*52n;
            }else{
                // its a number
                diff = diff*10n
            }
        }
        document.getElementById("50perc").innerText = diff;
        document.getElementById("diffIndic").innerText = perc;
        return;
    }
    if (window.vanity_settings.caseSensitive === false){
        var diff = 1n;
        var perc = 1n;
        for (var i = 0; i<text.length; i++){
            perc = perc * 36n;
            if (isNaN(text.charAt(i)) === true){
                // its a letter
                diff = diff*26n;
            }else{
                // its a number
                diff = diff*10n
            }
        }
        document.getElementById("diffIndic").innerText = perc;
        return document.getElementById("50perc").innerText = diff;
    }
}
</script>