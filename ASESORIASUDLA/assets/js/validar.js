



function sololetras(e) {

    var key;

    if (window.event) // IE
    {
        key = e.keyCode;
    }
    else if (e.which) // Netscape/Firefox/Opera
    {
        key = e.which;
    }

    if (key < 65 || key > 122 ) {
        return false;
    }

    return true;
}