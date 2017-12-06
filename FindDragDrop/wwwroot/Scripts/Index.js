$(document).ready(function () {

    $.ajax({
        url: "/Home/GetJson",
        type: "GET",
        success: function (result) {
            $("#myPartialContainer").html(
                "<img src=https://finddragdropimages.blob.core.windows.net/images/" + result.objectList[0].image + " class='draggable' id='dragFirst'/>" +
                //"<img src=" + result[1].img + " class='draggable' id='dragSecond'/>" +
                //"<img src=" + result[2].img + " class='draggable' id='dragThird'/>" +
                    "<p class= 'droppable' id= 'dropFirst'>" + result.objectList[0].word + "</p >"
                //"<p class= 'droppable' id= 'dropSecond'>" + result[1].word + "</p >" +
                //"<p class= 'droppable' id= 'dropThird'>" + result[2].word + "</p >"
            );



                success: $(function () {
                    $("#dragFirst").draggable({
                        scope: "first"
                    });

                    $("#dropFirst").droppable({
                        scope: "first",
                        drop: function (event, ui) {
                            $(this).css("background-color", "SeaGreen")
                        },
                        out: function (event, ui) {
                            $(this).css("background-color", "")
                        }
                    });
                });
        }

    });


});

            

            //    $("#dragSecond").draggable({
            //        scope: "second"
            //    });

                //$("#dropSecond").droppable({
                //    scope: "second",
                //    drop: function (event, ui) {
                //        $(this).css("background-color", "SeaGreen")
                //    },
                //    out: function (event, ui) {
                //        $(this).css("background-color", "")
                //    }
                //});

                //$("#dragThird").draggable({
                //    scope: "third"
                //});

                //$("#dropThird").droppable({
                //    scope: "third",
                //    drop: function (event, ui) {
                //        $(this).css("background-color", "SeaGreen")
                //    },
                //    out: function (event, ui) {
                //        $(this).css("background-color", "")
                //    }
                //});

          




