

function getCategory() {
    $.ajax({
        url: "/api/GestorMarcas/GetCategory/",
        type: "GET",
        data: { bornDate: '03/05/1976', sex: 'M' },
        statusCode: {
            200: function (data) {
                jQuery("#content").hide("slow", function () {
                    $(this).html(data).show("slow");
                });

            },
            404: function () { alert("fail"); }
        }
    });
}

