$(function () {
    $('.datepicker').datepicker(
        {
            dateFormat = 'yy-mm-dd',
            minDate: new Date(),
            maxDate: AddSubstractMonths(new Date(), 2);
        }
    );

    
});