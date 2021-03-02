// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {
    var stt_is_shown = false;
    $(window).scroll(function () {
        var win_height = 100;
        var scroll_top = $(document).scrollTop();
        if (scroll_top > win_height && !stt_is_shown) {
            stt_is_shown = true;
            $("#scroll-to-top").fadeIn();
        } else if (scroll_top < win_height && stt_is_shown) {
            stt_is_shown = false;
            $("#scroll-to-top").fadeOut();
        }
    });
    $("#scroll-to-top").click(function (e) {
        e.preventDefault();
        $('html, body').animate({
            scrollTop: 0
        }, 1000);
    });
});

$(function () {
    setActiveClass();
})

function setActiveClass() {
    var path = window.location.pathname;
    var links = $(".nav-link");
   console.log(path)
    for (let index = 0; index < links.length; index++) {
        console.log(links[index].attributes.href.value)
        if (links[index].attributes.href.value == path) {
            links[index].classList.add("active")
        }
    }
}


