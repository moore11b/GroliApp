$(document).ready(function _groceryItemCreate() {
    let connection = new signalR
        .HubConnectionBuilder()
        .withUrl("/groceryItemHub")
        .build();
    connection.start().catch(function _connectionStartError(err) {
        console.error(err.toString());
    });
    connection.on("GroceryItemUpdated", function _groceryItemUpdated(message) {
        let tokens = message.split(':');
        let command = tokens[0];
        let params = tokens[1];
        if (command === "GROCERY-ITEM-ADDED") {
            _updateGroceryItemsTable(params);
        } else if (command === "GROCERY-ITEM-REMOVED") {
            let rowToDelete = "#row-" + params;
            $(rowToDelete).fadeOut();
            $('#tbody-groceryItem').remove(rowToDelete);
            $('#messageArea').html("A groceryItem was removed!");
            $('#alertArea').show(400);
        } else if (command === "GROCERY-ITEM-CHECKED") {
            let rowToUpdate = "#row-" + params;
            $(rowToUpdate).fadeOut();
            $('#tbody-groceryItem');
            window.location.reload();
            $(rowToUpdate).fadeIn();
            $('#alertArea').show(400);
        }
    });
    $('#alertCloseBtn').on('click', function _hideAlert() {
        $('#alertArea').hide(400);
    });
    $('#groceryItemForm').on('submit', function _submitGroceryItemForm(event) {
        event.preventDefault();
        let $form = $(this);
        $.ajax({
            url: $form.attr('action'),
            type: $form.attr('method'),
            data: $form.serialize(),
            success: function _success(response) {
                connection.invoke("SendToAll", "GROCERY-ITEM-ADDED:" + response.id)
                    .catch(function _connectionStartError(err) {
                        console.error(err.toString());
                    });
            },
            error: function _error() {
            }
        });
    });
    function _updateGroceryItemsTable(groceryItemId) {
        $.ajax({
            url: '/groceryList/GroceryItemRow/' + groceryItemId,
            success: function _success(response) {
                $('#messageArea').html("A new groceryItem was added!");
                $('#alertArea').show(400);
                $('#tbody-groceryItem').append(response);
                $('#row-createGroceryItem').fadeOut("slow", function _remove() {
                    $('#tbody-groceryItem').remove('#row-createGroceryItem');
                    $('#createNewGroceryItemBtn').show();
                });
            },
            error: function _error() {
            }
        });
    }
    $('#groceryItemForm').on('submit', function _submitGroceryItemForm(event) {
    });
    $('.removeBtn').on('click', function _removeGroceryItem(event) {
        event.preventDefault();
        let $link = $(this);
        let theUrl = $link.attr('href');
        let tokens = theUrl.split('/');
        let id = tokens[tokens.length - 1];
        $.ajax({
            url: theUrl,
            type: "post",
            data: { id: id },
            success: function _success(response) {
                connection.invoke("SendToAll", "GROCERY-ITEM-REMOVED:" + response.id)
                    .catch(function _connectionStartError(err) {
                        console.error(err.toString());
                    });
            },
            error: function _error() {
                $('#messageArea').html("An unknown error occurred!");
                $('#alertArea').show(400);
            }
        });
    });
    $('.groceryCheckItemBtn').on('click', function _checkGroceryItem(event) {
        event.preventDefault();
        let $link = $(this);
        let theUrl = $link.attr('href');
        let tokens = theUrl.split('/');
        let id = tokens[tokens.length - 1];
        $.ajax({
            url: theUrl,
            type: "post",
            data: { id: id },
            success: function _success(response) {
                connection.invoke("SendToAll", "GROCERY-ITEM-CHECKED:" + response.id)
                    .catch(function _connectionStartError(err) {
                        console.error(err.toString());
                    });
            },
            error: function _error() {
                $('#messageArea').html("Weird.....!");
                $('#alertArea').show(400);
            }
        });
    });
    $('#createNewGroceryItemBtn').on('click', function _showGroceryItemInputs() {
        $('#createNewGroceryItemBtn').hide();
        $.ajax({
            url: "/groceryitem/create/",
            success: function _success(response) {
                $('#tbody-groceryItem').prepend(response);
                $('#row-createGroceryItem').fadeIn("slow", function _showInputs() {
                    $('#cancelCreateGroceryItemBtn').on('click', function _cancelCreate(event) {
                        event.preventDefault();
                        $('#row-createGroceryItem').fadeOut("slow", function _remove() {
                            $('#tbody-groceryItem').remove('#row-createGroceryItem');
                            $('#createNewGroceryItemBtn').show();
                        });
                    });
                });
            },
            error: function _error() {
                $('#createNewGroceryItemBtn').show();
            }
        });
    });

});
