$(document).ready(function () {
   
    var hideCreate = function () {
        $('#createPrivUser').hide();
    };
    var hideDelete = function () {
        $('#deletePrivUser').hide();
    };
    //GroceryPermissionsUpdated
    var renderCreateFields = function () {
        $.ajax({
            success: function () {
                $('#grantPermission').on('click', function () {
                    $('#grantPermission').hide();
                    $('#createPrivUser').show();
                })
            }
        })
    };
    var renderDeleteFields = function () {
        $.ajax({
            success: function () {
                $('#revokePermission').on('click', function () {
                    $('#revokePermission').hide();
                    $('#deletePrivUser').show();
                })
            }
        })
    };

    //permission submission... 
    $('#permForm').on('submit', function _grant(event) {
        //event.preventDefault();
        let listId = $('#grantListId').val();
        let selectValue = $('#selectValue :selected').val();
        $.ajax({
            url: "/grocerylist/grantpermission/",
            type: "post",
            data: {
                listId: listId, userId: selectValue
            },
            success: function (response) {
                console.log(response);
            },
            error: function (response) {
                location.reload();
                console.log(response);
            }
        })
        event.preventDefault();
    })

    //hides the create windows
    $(document).on("click", "#cancelCreate", function () {
        $('#createPrivUser').hide();
        $('#grantPermission').show();
    })
    $(document).on("click", "#cancelDelete", function () {
        $('#deletePrivUser').hide();
        $('#revokePermission').show();
    })
    $('#revokeForm').on('submit', function _revoke(event) {
       // event.preventDefault();
        let listId = $('#revokeListId').val();
        let selectValueR = $('#selectValueRevoke :selected').val();
        $.ajax({
            url: "/grocerylist/revokepermission/",
            type: "post",
            data: {
                listId: listId, userId: selectValueR
            },
            success: function (response) {
                console.log(response);
            },
            error: function (response) {
                location.reload();
                console.log(response);
            }
        })
        event.preventDefault();
    })

    
    hideDelete();
    hideCreate();
    renderCreateFields();
    renderDeleteFields();
});