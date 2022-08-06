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



function RedesSociales() {

    Swal.fire({
        title: 'Redes Sociales',
        html: '  <div class="row ej">   <a class="AWhatsapp" href="https://www.whatsapp.com/" target="_blank">  <div class="col-3 colum1" >  Whatsapp </div> </a>    <a class="AWhatsapp" href="https://www.facebook.com/"  target="_blank"> <div class="col-3   colum2"> Facebook</div>  </a>   <a class="AInstagram" href="https://www.instagram.com/" target="_blank">  <div class="col-3   colum3">  Instagram</div>  </a>   </div>',
        showCloseButton: true,
        background: ' linear-gradient(#ffff,#d9dfe8)',

        focusConfirm: false,

    })



    console.log("Correcto");
}