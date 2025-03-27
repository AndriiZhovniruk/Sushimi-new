
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
    document.getElementById("modal-order").classList.add("open")
})

document.getElementById("close-modal-btn").addEventListener("click", function () {
    document.getElementById("modal-order").classList.remove("open")
})

window.addEventListener('keydown', (e) => {
    if (e.key === "Escape") {
        document.getElementById("modal-order").classList.remove("open")
    }
})
document.getElementById("open-modal-btn").addEventListener("click", function () {
    fetch('/Cart/Index')
        .then(response => response.text())
        .then(html => {
            document.getElementById("cart-content").innerHTML = html;
            document.getElementById("modal-order").classList.add("open");
        });
});

document.getElementById("close-modal-btn").addEventListener("click", function () {
    document.getElementById("modal-order").classList.remove("open");
});
