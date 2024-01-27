// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $("a[href^='#']").on('click', function (event) {
        if (this.hash !== "") {
            event.preventDefault();
            var hash = this.hash;
            $('html,body').animate({
                scrollTop: $(hash).offset().top

            }, 1000, function () {
                window.location.hash=hash
            });
        }
    });
});

$(function () {
    $('[data-toggle="tooltip"]').tooltip();
    $('.btn-group-fab').on('click', function () {
        $('.btn-group-fab').toggleClass('active');
    });
});