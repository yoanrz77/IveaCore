    var GetIndexForDropDownListClicked;

        function SelectedValue(ddlObject) {
            var selectedIndex = ddlObject.selectedIndex;
            GetIndexForDropDownListClicked = selectedIndex;
        }

        $(document).ready(function () {
        console.log('it is ready');
            var descriptions = {
        '1': ['1', '2', '3'],
                '2': ['4', '5', '6'],
                '3': ['7', '8', '9'],
                //'1- (1 a 3 puntos). Agro-ecosistemas con signos de degradación evidentes, poco integrado y con baja calidad de paisaje.': ['4', '5', '6'],
                //'2- (4 a 6 puntos). Agro-ecosistemas ligeramente integrados con bajos niveles de conservación y sin presencia de hábitat naturales.': ['4', '5', '6'],
                //'3- (7 a 9 puntos). Agro-ecosistemas con funciones integradas en policultivos, captura y conservación de agua, hábitats naturales y buena calidad del paisaje.': ['7','8', '9'],
            }

            var $Value_CFV = $('#Value_CFV');
            $('#Description_CFV').change(function () {
                //var description_CFV = $(this).val();
                var myDescriptions = descriptions[GetIndexForDropDownListClicked] || [];
                var html = $.map(myDescriptions, function (myDescription) {
                    return '<option value="' + myDescription + '">' + myDescription + '</option>'
                }).join('');
                $Value_CFV.html(html)
            });

            var $Value_DAS = $('#Value_DAS');
            $('#Description_DAS').change(function () {
                var myDescriptions = descriptions[GetIndexForDropDownListClicked] || [];
                var html = $.map(myDescriptions, function (myDescription) {
                    return '<option value="' + myDescription + '">' + myDescription + '</option>'
                }).join('');
                $Value_DAS.html(html)
            });

            var $Value_DFS = $('#Value_DFS');
            $('#Description_DFS').change(function () {
                var myDescriptions = descriptions[GetIndexForDropDownListClicked] || [];
                var html = $.map(myDescriptions, function (myDescription) {
                    return '<option value="' + myDescription + '">' + myDescription + '</option>'
                }).join('');
                $Value_DFS.html(html)
            });

            var $Value_MPE = $('#Value_MPE');
            $('#Description_MPE').change(function () {
                var myDescriptions = descriptions[GetIndexForDropDownListClicked] || [];
                var html = $.map(myDescriptions, function (myDescription) {
                    return '<option value="' + myDescription + '">' + myDescription + '</option>'
                }).join('');
                $Value_MPE.html(html)
            });

            var $Value_NCS = $('#Value_NCS');
            $('#Description_NCS').change(function () {
                var myDescriptions = descriptions[GetIndexForDropDownListClicked] || [];
                var html = $.map(myDescriptions, function (myDescription) {
                    return '<option value="' + myDescription + '">' + myDescription + '</option>'
                }).join('');
                $Value_NCS.html(html)
            });

            var $Value_NES = $('#Value_NES');
            $('#Description_NES').change(function () {
                var myDescriptions = descriptions[GetIndexForDropDownListClicked] || [];
                var html = $.map(myDescriptions, function (myDescription) {
                    return '<option value="' + myDescription + '">' + myDescription + '</option>'
                }).join('');
                $Value_NES.html(html)
            });

            var $Value_NRS = $('#Value_NRS');
            $('#Description_NRS').change(function () {
                var myDescriptions = descriptions[GetIndexForDropDownListClicked] || [];
                var html = $.map(myDescriptions, function (myDescription) {
                    return '<option value="' + myDescription + '">' + myDescription + '</option>'
                }).join('');
                $Value_NRS.html(html)
            });

            var $Value_PES = $('#Value_PES');
            $('#Description_PES').change(function () {
                var myDescriptions = descriptions[GetIndexForDropDownListClicked] || [];
                var html = $.map(myDescriptions, function (myDescription) {
                    return '<option value="' + myDescription + '">' + myDescription + '</option>'
                }).join('');
                $Value_PES.html(html)
            });

            var $Value_RCES = $('#Value_RCES');
            $('#Description_RCES').change(function () {
                var myDescriptions = descriptions[GetIndexForDropDownListClicked] || [];
                var html = $.map(myDescriptions, function (myDescription) {
                    return '<option value="' + myDescription + '">' + myDescription + '</option>'
                }).join('');
                $Value_RCES.html(html)
            });

            var $Value_RCS = $('#Value_RCS');
            $('#Description_RCS').change(function () {
                var myDescriptions = descriptions[GetIndexForDropDownListClicked] || [];
                var html = $.map(myDescriptions, function (myDescription) {
                    return '<option value="' + myDescription + '">' + myDescription + '</option>'
                }).join('');
                $Value_RCS.html(html)
            });

            var $Value_RES = $('#Value_RES');
            $('#Description_RES').change(function () {
                var myDescriptions = descriptions[GetIndexForDropDownListClicked] || [];
                var html = $.map(myDescriptions, function (myDescription) {
                    return '<option value="' + myDescription + '">' + myDescription + '</option>'
                }).join('');
                $Value_RES.html(html)
            });

            var $Value_VBS = $('#Value_VBS');
            $('#Description_VBS').change(function () {
                var myDescriptions = descriptions[GetIndexForDropDownListClicked] || [];
                var html = $.map(myDescriptions, function (myDescription) {
                    return '<option value="' + myDescription + '">' + myDescription + '</option>'
                }).join('');
                $Value_VBS.html(html)
            });

            var $Value_VBS = $('#Value_VBS');
            $('#Description_VBS').change(function () {
                var myDescriptions = descriptions[GetIndexForDropDownListClicked] || [];
                var html = $.map(myDescriptions, function (myDescription) {
                    return '<option value="' + myDescription + '">' + myDescription + '</option>'
                }).join('');
                $Value_VBS.html(html)
            });
        });