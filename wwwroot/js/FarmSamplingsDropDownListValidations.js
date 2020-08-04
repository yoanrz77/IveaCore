
function GetListElments() {
    $.ajax
        ({
            type: 'GET',
            url: listUrl,
            dataType: 'json',
            data: {},
            success: function (data) {
                //alert(data);
                var listKey = Object.getOwnPropertyNames(data);
                for (var l in listKey) {

                    var html = "<option>-- Select Value--</option>";

                    if (listKey[l] == "Farm") {
                        var dropDownF = $("select[id*=Id_" + listKey[l] + "]");
                        var mySelected = dropDownF.attr("datavalue");
                        html += $.map(data[listKey[l]], function (listDescription) {

                            var sel = (mySelected != undefined && mySelected.length > 0) ? "selected" : "";

                            if (mySelected == listDescription["id"]) {
                                var expresion = '<option ' + sel + ' value="' + listDescription["id"] + '">' + listDescription["description"] + '</option>'
                            }
                            else {
                                var expresion = '<option value="' + listDescription["id"] + '">' + listDescription["description"] + '</option>'
                            }
                            return expresion
                        }).join('');

                        dropDownF.html(html);
                    }
                    else { 
                        var dropDown = $("select[id*=Description_" + listKey[l] + "]");
                        var mySelected = dropDown.attr("datavalue");
                        html += $.map(data[listKey[l]], function (listDescription) {

                            var sel = (mySelected != undefined && mySelected.length > 0) ? "selected" : "";

                            if (mySelected == listDescription["description"]) {
                                var expresion = '<option ' + sel + ' value="' + listDescription["description"] + '">' + listDescription["description"] + '</option>'
                            }
                            else {
                                var expresion = '<option value="' + listDescription["description"] + '">' + listDescription["description"] + '</option>'
                            }
                            return expresion
                        }).join('');

                        dropDown.html(html);
                    }
                }
            },
            error: function (ex) {
                var r = jQuery.parseJSON(response.responseText);
                alert("Message: " + r.Message);
            }
        });
}

    $(document).ready(function () {
        GetListElments();
        //console.log('it is ready');

        var descriptions = {
            '1': ['1', '2', '3'],
            '2': ['4', '5', '6'],
            '3': ['7', '8', '9'],
        }

        var $Value_CFV = $('#Value_CFV');
        $('#Description_CFV').change(function () {
            var GetIndexForDropDownListClicked = document.getElementById("Description_CFV").selectedIndex;
            var myDescriptions = descriptions[GetIndexForDropDownListClicked] || [];
            var html = $.map(myDescriptions, function (myDescription) {
                return '<option value="' + myDescription + '">' + myDescription + '</option>'
            }).join('');
            $Value_CFV.html(html)
        });

        var $Value_DAS = $('#Value_DAS');
        $('#Description_DAS').change(function () {
            var GetIndexForDropDownListClicked = document.getElementById("Description_DAS").selectedIndex;
            var myDescriptions = descriptions[GetIndexForDropDownListClicked] || [];
            var html = $.map(myDescriptions, function (myDescription) {
                return '<option value="' + myDescription + '">' + myDescription + '</option>'
            }).join('');
            $Value_DAS.html(html)
        });

        var $Value_DFS = $('#Value_DFS');
        $('#Description_DFS').change(function () {
            var GetIndexForDropDownListClicked = document.getElementById("Description_DFS").selectedIndex;
            var myDescriptions = descriptions[GetIndexForDropDownListClicked] || [];
            var html = $.map(myDescriptions, function (myDescription) {
                return '<option value="' + myDescription + '">' + myDescription + '</option>'
            }).join('');
            $Value_DFS.html(html)
        });

        var $Value_MPE = $('#Value_MPE');
        $('#Description_MPE').change(function () {
            var GetIndexForDropDownListClicked = document.getElementById("Description_MPE").selectedIndex;
            var myDescriptions = descriptions[GetIndexForDropDownListClicked] || [];
            var html = $.map(myDescriptions, function (myDescription) {
                return '<option value="' + myDescription + '">' + myDescription + '</option>'
            }).join('');
            $Value_MPE.html(html)
        });

        var $Value_NCS = $('#Value_NCS');
        $('#Description_NCS').change(function () {
            var GetIndexForDropDownListClicked = document.getElementById("Description_NCS").selectedIndex;
            var myDescriptions = descriptions[GetIndexForDropDownListClicked] || [];
            var html = $.map(myDescriptions, function (myDescription) {
                return '<option value="' + myDescription + '">' + myDescription + '</option>'
            }).join('');
            $Value_NCS.html(html)
        });

        var $Value_NES = $('#Value_NES');
        $('#Description_NES').change(function () {
            var GetIndexForDropDownListClicked = document.getElementById("Description_NES").selectedIndex;
            var myDescriptions = descriptions[GetIndexForDropDownListClicked] || [];
            var html = $.map(myDescriptions, function (myDescription) {
                return '<option value="' + myDescription + '">' + myDescription + '</option>'
            }).join('');
            $Value_NES.html(html)
        });

        var $Value_NRS = $('#Value_NRS');
        $('#Description_NRS').change(function () {
            var GetIndexForDropDownListClicked = document.getElementById("Description_NRS").selectedIndex;
            var myDescriptions = descriptions[GetIndexForDropDownListClicked] || [];
            var html = $.map(myDescriptions, function (myDescription) {
                return '<option value="' + myDescription + '">' + myDescription + '</option>'
            }).join('');
            $Value_NRS.html(html)
        });

        var $Value_PES = $('#Value_PES');
        $('#Description_PES').change(function () {
            var GetIndexForDropDownListClicked = document.getElementById("Description_PES").selectedIndex;
            var myDescriptions = descriptions[GetIndexForDropDownListClicked] || [];
            var html = $.map(myDescriptions, function (myDescription) {
                return '<option value="' + myDescription + '">' + myDescription + '</option>'
            }).join('');
            $Value_PES.html(html)
        });

        var $Value_RCES = $('#Value_RCES');
        $('#Description_RCES').change(function () {
            var GetIndexForDropDownListClicked = document.getElementById("Description_RCES").selectedIndex;
            var myDescriptions = descriptions[GetIndexForDropDownListClicked] || [];
            var html = $.map(myDescriptions, function (myDescription) {
                return '<option value="' + myDescription + '">' + myDescription + '</option>'
            }).join('');
            $Value_RCES.html(html)
        });

        var $Value_RCS = $('#Value_RCS');
        $('#Description_RCS').change(function () {
            var GetIndexForDropDownListClicked = document.getElementById("Description_RCS").selectedIndex;
            var myDescriptions = descriptions[GetIndexForDropDownListClicked] || [];
            var html = $.map(myDescriptions, function (myDescription) {
                return '<option value="' + myDescription + '">' + myDescription + '</option>'
            }).join('');
            $Value_RCS.html(html)
        });

        var $Value_RES = $('#Value_RES');
        $('#Description_RES').change(function () {
            var GetIndexForDropDownListClicked = document.getElementById("Description_RES").selectedIndex;
            var myDescriptions = descriptions[GetIndexForDropDownListClicked] || [];
            var html = $.map(myDescriptions, function (myDescription) {
                return '<option value="' + myDescription + '">' + myDescription + '</option>'
            }).join('');
            $Value_RES.html(html)
        });

        var $Value_VBS = $('#Value_VBS');
        $('#Description_VBS').change(function () {
            var GetIndexForDropDownListClicked = document.getElementById("Description_VBS").selectedIndex;
            var myDescriptions = descriptions[GetIndexForDropDownListClicked] || [];
            var html = $.map(myDescriptions, function (myDescription) {
                return '<option value="' + myDescription + '">' + myDescription + '</option>'
            }).join('');
            $Value_VBS.html(html)
        });

        var $Value_AF = $('#Value_AF');
        $('#Description_AF').change(function () {
            var GetIndexForDropDownListClicked = document.getElementById("Description_AF").selectedIndex;
            var myDescriptions = descriptions[GetIndexForDropDownListClicked] || [];
            var html = $.map(myDescriptions, function (myDescription) {
                return '<option value="' + myDescription + '">' + myDescription + '</option>'
            }).join('');
            $Value_AF.html(html)
        });
    });