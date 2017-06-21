$(function () {

    $(".right.carousel-control").click(function () {

        if ($(".item.active").next().length) {
            $(".active").removeClass("active").next(".item").addClass("active");
        }
        else if ($(".item.active").prev().length == 0 && $(".item.active").next().length == 0) {
            return $(".item.active");
        }
        else {
            $(".active").removeClass("active").prevAll().last(".item").addClass("active");
        }
    });

    $(".left.carousel-control").click(function () {

        if ($(".item.active").prev().length) {
            $(".active").removeClass("active").prev(".item").addClass("active");
        }
        else if ($(".item.active").prev().length == 0 && $(".item.active").next().length == 0) {
            return $(".item.active");
        }
        else {
            $(".active").removeClass("active").nextAll().last(".item").addClass("active");
        }
    });
});
