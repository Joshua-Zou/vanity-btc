
var targetText;
var totalAdrs = 0;
onmessage = function (e) {
    let incoming = JSON.parse(e.data);
    if (incoming.status === "start") {
        targetText = incoming.text;
        if (incoming.data.caseSensitive === false) targetText = targetText.toLowerCase();
        while (true) {
            totalAdrs++;
            if (totalAdrs % 100 === 0) {
                let datax = {
                    status: "data-dump",
                    totalAdrs: "new 100"
                }
                postMessage(JSON.stringify(datax))
            }
            let wallet = generateKeyPairs();
            let address = wallet.address;
            if (incoming.data.caseSensitive === false) address = address.toLowerCase();
            if (incoming.data.anywhere === true && address.includes(targetText)) {
                let data = {
                    status: "found",
                    address: wallet.address,
                    secret: wallet.privateKey,
                    xPub: wallet.publicKey
                }
                return postMessage(JSON.stringify(data))
            } else {
                if (incoming.data.mode === "prefix" && address.slice(1).startsWith(targetText)) {
                    let data = {
                        status: "found",
                        address: wallet.address,
                        secret: wallet.privateKey,
                        xPub: wallet.publicKey
                    }
                    return postMessage(JSON.stringify(data))
                } else if (incoming.data.mode === "suffix" && address.endsWith(targetText)) {
                    let data = {
                        status: "found",
                        address: wallet.address,
                        secret: wallet.privateKey,
                        xPub: wallet.publicKey
                    }
                    return postMessage(JSON.stringify(data))
                }
            }
        }
    }
};

function generateKeyPairs() {
    const litecore = require("litecore-lib");
    const crypto = require('crypto')
    var value = new Buffer(crypto.randomBytes(100));
var hash = litecore.crypto.Hash.sha256(value);
var bn = litecore.crypto.BN.fromBuffer(hash);

    var privateKey = new litecore.PrivateKey(bn)
    const address = privateKey.toAddress().toString();
    privateKey = privateKey.toString();
    const publicKey = address.toString("hex");
    return { address, privateKey, publicKey };
}
