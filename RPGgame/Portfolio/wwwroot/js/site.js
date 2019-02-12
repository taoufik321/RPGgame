// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const uri = "https://localhost:44388/api/posts";
let values = null;

$(document).ready(function () {
    getData();
});

function getData() {
    $.ajax({
        type: "GET",
        url: uri,
        cache: false,
        success: function (data) {
            console.log(data);

            const tBody = $("#data");

            $(tBody).empty();

            // getCount(data.length);

            $.each(data, function (key, item) {
                var date = new Date(item.publishedDate);


                const tr = $("<div class='wow fadeInUp color-white media' data-wow-delay='1.2s'><div class='media-object media-left'><i class='fa fa-laptop'></i></div>")
                    .append($("<h3 class='media-heading title'></h3>").text(item.title))
                    .append($("<h3 class='media-heading date'></h3>").text((date.getMonth() + 1) + '/' + date.getDate() + '/' + date.getFullYear()))
                    .append($("<p class='color-white content'></p>").text(item.content));
                tr.appendTo(tBody);
            });

            values = data;

            console.log(values);

            var date = new Date(values[0]["publishedDate"]);
            console.log((date.getMonth() + 1) + '/' + date.getDate() + '/' + date.getFullYear());

            console.log(values[0]["publishedDate"]);

            console.log(values[0]["publishedDate"]);

            console.log(values[0]["content"]);

            console.log(values[1]["title"]);

            //document.getElementById("demo2").innerHTML = values[1]["title"];
        }
    });
}

//function getCount(data) {
//    const el = $("#data");
//    let name = "to-do";
//    if (data) {
//        if (data > 1) {
//            name = "to-dos";
//        }
//        el.text(data + " " + name);
//    } else {
//        el.text("No " + name);
//    }
//}

//function addItem() {
//    const item = {
//        name: $("#add-name").val(),
//        isComplete: false
//    };

//    $.ajax({
//        type: "POST",
//        accepts: "application/json",
//        url: uri,
//        contentType: "application/json",
//        data: JSON.stringify(item),
//        error: function (jqXHR, textStatus, errorThrown) {
//            alert("Something went wrong!");
//        },
//        success: function (result) {
//            getData();
//            $("#add-name").val("");
//        }
//    });
//}

//function deleteItem(id) {
//    $.ajax({
//        url: uri + "/" + id,
//        type: "DELETE",
//        success: function (result) {
//            getData();
//        }
//    });
//}

//function editItem(id) {
//    $.each(todos, function (key, item) {
//        if (item.id === id) {
//            $("#edit-name").val(item.name);
//            $("#edit-id").val(item.id);
//            $("#edit-isComplete")[0].checked = item.isComplete;
//        }
//    });
//    $("#spoiler").css({ display: "block" });
//}

//$(".my-form").on("submit", function () {
//    const item = {
//        name: $("#edit-name").val(),
//        isComplete: $("#edit-isComplete").is(":checked"),
//        id: $("#edit-id").val()
//    };

//    $.ajax({
//        url: uri + "/" + $("#edit-id").val(),
//        type: "PUT",
//        accepts: "application/json",
//        contentType: "application/json",
//        data: JSON.stringify(item),
//        success: function (result) {
//            getData();
//        }
//    });

//    closeInput();
//    return false;
//});

//function closeInput() {
//    $("#spoiler").css({ display: "none" });
//}