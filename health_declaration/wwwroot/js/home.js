var home = {} || home;
home.drawdistrictsbyprovinId = function () {
    var proId = parseInt($('#ProvinceId').val());
    $.ajax({
        url: `/Home/GetsDistrictByProvinceId/${proId}`,
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#DistrictId').empty();
            $('#DistrictId').append(
                `<option value="0">-Chọn-</option>`
            );
            $.each(data.districts, function (i, v) {
                $('#DistrictId').append(
                    `<option value="${v.districtId}">${v.districtName}</option>`
                );
            });
        }
    });
}
home.drawwardbyDistrictId = function () {
    var proId = parseInt($('#ProvinceId').val());
    var disId = parseInt($('#DistrictId').val());
    resObj = {};
    resObj.ProvinceId = proId;
    resObj.DistrictId = disId;
    $.ajax({
        url: `/Home/GetsWardByProvinceId`,
        method: "POST",
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(resObj),
        success: function (data) {
            $('#WardId').empty();
            $('#WardId').append(
                `<option value="0">-Chọn-</option>`
            );
            $.each(data.wards, function (i, v) {
                $('#WardId').append(
                    `<option value="${v.wardId}">${v.wardName}</option>`
                );
            });
        }
    });
}