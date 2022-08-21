
$(document).ready(function () {

    $(".money").hide();
    $(".basket").hide();
    $(".item").hide();

    $("#donationType").on("change", function () {

        var val = $(this).val();
        if (val == "1") {
            $(".money").show();
            $(".basket").hide();
            $(".item").hide();
        }

        if (val == "2") {
            $(".money").hide();
            $(".basket").show();
            $(".item").hide();
        }

        if (val == "3") {
            $(".money").hide();
            $(".basket").hide();
            $(".item").show();;
        }
    });
})

const { formattribute } = require("modernizr");