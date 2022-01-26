$(document).ready(function () {
  $(".owl-carousel").owlCarousel({
    items: 1,
  });

  window.onscroll = function () {
    myFunction();
  };

  var header = document.getElementById("page-header");
  function myFunction() {
    if (window.pageYOffset > 300 ) {
      console.log(header)

      $(header).css({
          "background-color" : "rgba(0, 0, 0, 0.8)"
      })
    } else {
        $(header).css({
            "background-color" : "transparent"
        })
    }
  }

  //document.getElementById("menu-btn").addEventListener("click", () => {
  //    $("#menu").css({
  //        "display" : "block"
  //    })
  //})
});



