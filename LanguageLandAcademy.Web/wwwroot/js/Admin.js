﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// انتخاب تمام دکمه‌های منو با کلاس "menu-item"
var menuItems = document.querySelectorAll(".menu-item");

// تعریف یک تابع برای افزودن کلاس "active" به دکمه منو انتخاب شده و حذف آن از دکمه‌های دیگر
function toggleActiveClass(event) {
    // حذف کلاس "active" از همه دکمه‌های منو
    menuItems.forEach(function (item) {
        item.classList.remove("active");
    });

    // افزودن کلاس "active" به دکمه منوی انتخاب شده
    event.target.classList.add("active");
}

// افزودن رویداد click به هر دکمه منو
menuItems.forEach(function (item) {
    item.addEventListener("click", toggleActiveClass);
});

function GeneratePass() {
    var nCode = document.getElementById("nationalCode").value;
    var accPass = document.getElementById("accPass");
    const d = new Date();
    var pass = "@Pass_" + nCode + d.getMinutes() + d.getSeconds();
    accPass.value = pass;
}
$(document).ready(function () {
    var username = document.getElementById("userName");
    const d = new Date();
    var uName = "@User_" + d.getSeconds() + d.getMinutes() + d.getHours() + d.getMonth();
    username.value = uName;
});