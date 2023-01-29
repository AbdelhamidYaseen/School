//elementen knop + button
const buttonElements = document.querySelectorAll('.buy-button');
console.log(buttonElements);
const cartElement = document.getElementById('cart');
console.log(cartElement);
// eventlisteners buttons
for (let i = 0; i < buttonElements.length; i++) {
	buttonElements[i].addEventListener('click', (event) => {
		const parent = event.target.parentNode;
		const children = parent.children;
		addToCart(children[0].textContent, 1, children[3].textContent, cartElement);
	});
}
// function addToCart
const addToCart = (title, amount, price, cart) => {
	const indexOfExistingItem = ItemExists(title, cart.children);
	if (indexOfExistingItem !== false) {
		updateAmount(indexOfExistingItem, cart);
		return;
	}
	const cartItem = document.createElement('article');
	cartItem.appendChild(createNode('h3', title));
	console.log(title);
	cartItem.appendChild(createNode('p', price));
	console.log(price);
	cartItem.appendChild(createNode('p', amount));
	console.log(amount);
	cart.appendChild(cartItem);
	console.log("adding to cart")
};
// function if item exists
const ItemExists = (title, cartChildren) => {
	for (let i = 0; i < cartChildren.length; i++) {
		if (cartChildren[i].children[0].textContent === title) return i;
	}
	return false;
};
//function creates node of item
const createNode = (element, text) => {
	const node = document.createElement(element);
	node.textContent = text;
	return node;
};
//function updates Amount
const updateAmount = (index, cart) => {
	cart.children[index].children[2].textContent =
		parseInt(cart.children[index].children[2].textContent) + 1;
		console.log("updates amount");
};
// items buttons, counters, total
const counter = document.getElementById('counter');
const total = document.getElementById('total');
console.log(total);
//eventlisteners button
for (let i = 0; i < buttonElements.length; i++) {
	buttonElements[i].addEventListener('click', (event) => {
		const parent = event.target.parentNode;
		const children = parent.children;
		const price = children[3].textContent.slice(1);
		console.log(price);
		total.textContent = `€${
			parseInt(total.textContent.slice(1)) + parseInt(price)
		}`;
		counter.textContent = parseInt(counter.textContent) + 1;
	});
}
