$(function () {
    $('.select2').select2();
    bsCustomFileInput.init();

    $.fn.refreshDataSelect2 = function (data) {
        this.select2('data', data);
        // Update options
        var $select = $(this[0]);
        var options = data.map(function (item) {
            return '<option value="' + item.value + '">' + item.text + '</option>';
        });
        $select.html(options.join('')).change();
    };
})