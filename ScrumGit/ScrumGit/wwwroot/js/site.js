// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    var altura = $('.menu').offset().top;
    $(window).on('scroll', function () {
        if ($(window).scrollTop() > altura) {
            $('.menu').addClass('menu-scrollbar');

        } else {
            $('.menu').removeClass('menu-scrollbar');
        }
    })

})    