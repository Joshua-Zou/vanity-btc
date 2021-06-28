var work = require('webworkify');
const identicon = require('identicon.js')
var threads = [];
var totalAdrs = 0;

document.getElementById("startButton").addEventListener("click", function () {
    totalAdrs = 0;
    start();
})
document.getElementById("stopButton").addEventListener("click", function () {
    for (let k = 0; k < threads.length; k++) {
        threads[k].terminate();
    }
    document.getElementById("statusIndic").innerText = "Stopped";
    document.getElementById("stopButton").disabled = "disabled";
    document.getElementById("startButton").disabled = undefined;
    totalAdrs = 0;
})
async function start() {
    document.getElementById("startButton").disabled = "disabled";
    document.getElementById("stopButton").disabled = undefined;
    document.getElementById("statusIndic").innerText = "Initializing threads...";
    window.startingTime = Date.now();
    window.vanity_settings.caseSensitive;
    for (var t = 0; t < window.vanity_settings.threads; t++) {
        let w = work(require('./ltcWorker.js'), {
            'name': "ltc vanity worker thread #" + t
        });
        w.addEventListener('message', function (ev) {
            manageIncomingData(ev);
        });
        let message = {
            status: "start",
            data: window.vanity_settings,
            text: document.getElementById('input').value
        }
        w.postMessage(JSON.stringify(message));
        threads.push(w);
    }
    document.getElementById("statusIndic").innerText = "Running...";
}
function manageIncomingData(ev) {
    let res = JSON.parse(ev.data);
    if (res.status === "found") {
        for (let p = 0; p < threads.length; p++) {
            threads[p].terminate()
        }
        document.getElementById("statusIndic").innerText = "Found!";
        document.getElementById("stopButton").disabled = "disabled";
        document.getElementById("startButton").disabled = undefined;
        document.getElementById("outputScr").innerText = res.secret;
        document.getElementById("outputAdr").innerText = res.address;
        var data = new identicon(res.address).toString();
        document.getElementById("identicon").innerHTML = '<img src="data:image/png;base64,' + data + '">';
    } else if (res.status === "data-dump") {
        totalAdrs = totalAdrs + 100;
        document.getElementById("totalAdrs").innerText = totalAdrs;
        var percent = Number(document.getElementById("50perc").innerText)*2;
        let indic = (totalAdrs/percent*100+"%");
        if (totalAdrs/percent*100 > 100) indic = "100%"
        document.getElementsByClassName("probability-bar")[0].style.width = indic;
        document.getElementById('probability-indic').innerText = ((totalAdrs/percent*100).toString().slice(0, 5)+"%")
        document.getElementById("generationSpeed").innerText = totalAdrs/((Date.now()/1000 - window.startingTime/1000)); 
    }
}


function sleep(ms) {
    return new Promise(resolve => setTimeout(resolve, ms));
}
window.addEventListener("beforeunload", function (e) {
    for (let k = 0; k < threads.length; k++) {
        threads[k].terminate();
    }                          //Webkit, Safari, Chrome
});