$(document).ready( function() {
  if($("#formTests").length) {
    $("#formTests").submit(function(event) {
      if($("button[type='submit']").hasClass("disabled")) {
        event.preventDefault();
      }
    });
    $("#formTests input[type='radio']").change(function() {
      if($("button[type='submit']").hasClass("disabled")) {
        var numberAnswers = 0;
        $("input[type='radio']").each(function () {
          if(this.checked) {
            numberAnswers++;
          }
        });
        if (numberAnswers == $("input[type='radio']").parent().parent().length) {
          $("button[type='submit']").removeClass("disabled");
        }
      }
    });
  }
});