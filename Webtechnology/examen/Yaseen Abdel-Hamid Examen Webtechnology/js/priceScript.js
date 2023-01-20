function calcPrice(e) {
    e.preventDefault();
    let priceFormData = new FormData(e.target);
    let amount = priceFormData.get("amount");
    let size = priceFormData.get("size");
    let type = priceFormData.get("type");

    let unitPrice = 0;
    switch(size){
        case "dik":
            unitPrice += 8;
            break;
        case "dun":
            unitPrice += 6;
            break;
        default:
            console.log("oeps... foutje");
            break;
    }

    switch(type){
        case "small":
            unitPrice += 2;
            break;
        case "normal":
            unitPrice += 2.5;
            break;
        case "big":
            unitPrice += 2.8;
            break;
        default:
            console.log("Niet gelukt... sorry");
            break;

    }

    let totalPrice = unitPrice * amount;
    document.getElementById("priceSpan").textContent = totalPrice;
}

document.getElementById("priceForm").addEventListener("submit", calcPrice);