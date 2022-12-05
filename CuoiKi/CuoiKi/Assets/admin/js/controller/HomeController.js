/**
 * Created by westilian on 1/19/14.
 */
var char = {
    init: function () {
        char.draw();
    },
    draw: (function () {
        var data;
        $.ajax({
            url: '/admin/ChiTietHoaDon/ThongKe',
            type: "POST",
            dataType: "json",
            success: function (response) {
                if (response.status == true) {
                    data = response.data;
                    //$.each(data, function (i, item) {

                    //    html += '<option value="' + item.id + '">' + item.tenDanhMuc +
                    //        '</option>'
                    //});

                    //$('#ddlDanhMuc').html(html);

                }
            }
        });
        var t;
        function size(animate) {
            if (animate == undefined) {
                animate = false;
            }
            clearTimeout(t);
            t = setTimeout(function () {
                $("canvas").each(function (i, el) {
                    $(el).attr({
                        "width": $(el).parent().width(),
                        "height": $(el).parent().outerHeight()
                    });
                });
                redraw(animate);
                var m = 0;
                $(".chartJS").height("");
                $(".chartJS").each(function (i, el) { m = Math.max(m, $(el).height()); });
                $(".chartJS").height(m);
            }, 30);
        }
        $(window).on('resize', function () { size(false); });


        function redraw(animation) {
            var options = {};
            if (!animation) {
                options.animation = false;
            } else {
                options.animation = true;
            }
            var pieData = [
                {
                    value: 60 ,
                    color: "#E67A77"
                },
                {
                    value: 60 ,
                    color: "#D9DD81"
                },
                {
                    value: 60 ,
                    color: "#79D1CF"
                }

            ];

            var myPie = new Chart(document.getElementById("pie-chart-js").getContext("2d")).Pie(pieData);
        }




        size(true);

    }())
}
char.init();

