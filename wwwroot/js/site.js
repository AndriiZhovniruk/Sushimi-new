
var toggleBtn = document.querySelector(".toggle_btn")
var toggleBtnIcon = document.querySelector(".toggle_btn i")
var dropDownMenu = document.querySelector(".dropdown_menu")


toggleBtn.onclick = function () {
    dropDownMenu.classList.toggle("open")
    var isOpen = dropDownMenu.classList.contains("open")

    toggleBtnIcon.classList = isOpen
        ? 'fa-solid fa-xmark'
        : 'fa-solid fa-bars'
}


document.getElementById("open-modal-btn").addEventListener("click", function () {
    updateCartModal();
    document.getElementById("modal-order").classList.add("open");
});

document.getElementById("close-modal-btn").addEventListener("click", function () {
    document.getElementById("modal-order").classList.remove("open");
});

window.addEventListener('keydown', (e) => {
    if (e.key === "Escape") {
        document.getElementById("modal-order").classList.remove("open");
    }
});
function updateCartModal() {
    fetch("/Cart/GetCartItems")
        .then(response => response.json())
        .then(cartItems => {
            let cartContent = document.getElementById("cart-content");
            if (cartItems.length === 0) {
                cartContent.innerHTML = "<p>Кошик порожній</p>";
            } else {
                let html = "<ul>";
                cartItems.forEach(item => {
                    html += `<li>${item.name} x${item.quantity} - ${item.totalPrice} грн</li>`;
                });
                html += "</ul>";
                html += `<p>Загальна сума: ${cartItems.reduce((sum, item) => sum + item.totalPrice, 0)} грн</p>`;
                cartContent.innerHTML = html;
            }
        });
}
