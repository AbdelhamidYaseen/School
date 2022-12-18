//#region IMPORTANT-README
/*
================================================================================
================================================================================
    code is gemaakt met begeleiding van deze sources:

    introductie         --->    https://makeschool.org/mediabook/oa/tutorials/ecommerce-tutorial-wd8/shopping-cart-tutorial/
    video-voorbeeld     --->    https://www.youtube.com/watch?v=YeFzkC2awTM&ab_channel=WebDevSimplified

    niet gekopieerd maar gebruikt om een houvast te hebben

================================================================================
================================================================================
*/
//#endregion
//page loading moet erin blijven
if (document.readyState == 'loading') {
    document.addEventListener('DOMContentLoaded', remove)
} else {
    remove()
}
//purchase item
function purchaseItem(title, price) {
    let cartItem = document.createElement('section')
    cartItem.classList.add('cart-row')
    let cartItems = document.getElementsByClassName('cart-items')[0]
    let cartItemNames = cartItems.getElementsByClassName('cart-title')
    let cartItemInputValue = cartItems.getElementsByClassName('quantity-input')
        //#region remove for example presentation
    for (let i = 0; i < cartItemNames.length; i++) {
        if (cartItemNames[i].innerText == title) {
            cartItemInputValue
            alert(`"${title}" bevindt zich al in het mandje`)
            return
        }
    }
        //#endregion
    //aanmaken van item in cart
    const cartInput = 
        `
        <section class="cart-row">
        <span class="cart-title">${title}</span>
        <span class="cart-quantity">
        <span class="cart-price">${price}</span>
        <input class="quantity-input" type="number" value="1">
        </span>
        <button class="remove" type="button">
        X
        </button>
        </section>
        `
    cartItem.innerHTML = cartInput
    cartItems.append(cartItem)
    cartItem.getElementsByClassName('remove')[0].addEventListener('click', removeItemEvent)
    cartItem.getElementsByClassName('quantity-input')[0].addEventListener('change', quantityChangeEvent)
    
}
    //event item bij cart te voegen
function addToCartEvent(event) {
    let itemButton = event.target
    let shopItem = itemButton.parentElement.parentElement
    let itemTitle = shopItem.getElementsByClassName('shop-item-title')[0].innerText
    let price = shopItem.getElementsByClassName('shop-item-price')[0].innerText
    purchaseItem(itemTitle, price)
    cartTotal()
}
    //event quantity veranderd(totalPrice update)
function quantityChangeEvent(event) {
    let input = event.target
    if (isNaN(input.value) || input.value <= 0) {
        input.value = 1
    }
    cartTotal()
}
    //berekent totalPrice
function cartTotal() {
    let cartItemRow = document.getElementsByClassName('cart-items')[0]
    let cartRows = cartItemRow.getElementsByClassName('cart-row')
    let total = 0
    for (let i = 0; i < cartRows.length; i++) {
        let cartRow = cartRows[i]
        let priceElement = cartRow.getElementsByClassName('cart-price')[0]
        let quantityElement = cartRow.getElementsByClassName('quantity-input')[0]
        let price = parseFloat(priceElement.innerText.replace('$', ''))
        let quantity = quantityElement.value
        //delen door 2 anders dubbele prijs
        total = total + (price/2 * quantity)
    }
    total = Math.round(total * 100) / 100
    document.getElementsByClassName('cart-total-price')[0].innerText = '$' + total
}
//remove item
function removeItemEvent(event) {
    let buttonClick = event.target
    buttonClick.parentElement.parentElement.remove()
    cartTotal()
}
function remove() {
    let removeItem = document.getElementsByClassName('remove')
    for (let i = 0; i < removeItem.length; i++) {
        let button = removeItem[i]
        button.addEventListener('click', removeItemEvent)
    }

    let quantity = document.getElementsByClassName('quantity-input')
    for (let i = 0; i < quantity.length; i++) {
        let input = quantity[i]
        input.addEventListener('change', quantityChangeEvent)
    }
    document.getElementsByClassName('btn-purchase')[0].addEventListener('click', purchaseClicked)
    cartTotal()
    let addToCartButtons = document.getElementsByClassName('shop-item-button')
    for (let i = 0; i < addToCartButtons.length; i++) {
        let button = addToCartButtons[i]
        button.addEventListener('click', addToCartEvent)
    }

}
//purchase cart
function purchaseClicked() {
    let cartItems = document.getElementsByClassName('cart-items')[0]
    alert(`Bedankt voor je aankoop`)
    while (cartItems.hasChildNodes()) {
        cartItems.removeChild(cartItems.firstChild)
    }
    cartTotal()
}
