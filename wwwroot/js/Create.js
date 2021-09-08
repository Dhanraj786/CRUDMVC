/*
$(document).ready(function () {
    //alert("ready!");
});*/


function PositionChange() {

    // alert("hiii");

    if ($("#Position").val() == 'Developer') {
        $("#drop").show()
       // alert("Inside Developer");
        var selectvalues = {
            "1": "Tushar Morker ",
            "2": "Dharmin Naik",
            "3": "Sonu Gulati ",
            "4": "Khushbu Maniar",
            "5": "Pratik Sanyaja",
            "6": "Krutika Patel",
            "7": "Moxa",
            "8": "Kaushik"
        };
        var $myselect = $('#myselect');
        $.each(selectvalues, function (key, value) {
            var $option = $("<option/>", {
                value: key,
                text: value
            });
            $myselect.append($option);
           
        });


    }
}
 

/*

    var $select1 = $('#Position'),
        $select2 = $('#TeamLeader'),
        $options = $select2.find('option');

    $select1.on('change', function () {
        $select2.html($options.filter('[value="' + this.value + '"]'));
    }).trigger('change');
*/