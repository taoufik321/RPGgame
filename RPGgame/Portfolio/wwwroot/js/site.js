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
                const tr = $("<table></table>")
                    .append($("<tr><td></td></tr>").text(item.title))
                    .append($("<tr><td></td></tr>").text(item.publishedDate))
                    .append($("<tr><td></td></tr>").text(item.content));
                tr.appendTo(tBody);
            });

            values = data;

            console.log(values);

            console.log(values[0]["title"]);

            console.log(values[1]["title"]);

            document.getElementById("demo").innerHTML = values[1]["title"];
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