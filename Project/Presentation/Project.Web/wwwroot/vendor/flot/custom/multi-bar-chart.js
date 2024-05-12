$(function() {

	var data1 = [
		["January", 10],
		["February", 8],
		["March", 4],
		["April", 13],
		["May", 17],
		["June", 9]
	];
	var data2 = [
		["January", 1],
		["February", 5],
		["March", 6],
		["April", 3],
		["May", 37],
		["June", 39]
	];

	$.plot($("#multiBarChart"), [{
		data: data1,
		bars: {
			show: true,
			barWidth: 0.2,
			align: "left",
		}
	}, {
		data: data2,
		bars: {
			show: true,
			barWidth: 0.2,
			align: "right",
		}
	}], {
		xaxis: {
			mode: "categories",
			tickLength: 0
		}
	});
	colors: ['#3888f3', '#2f99de', '#3c9fe0', '#49a6e2', '#56ace4', '#63b3e6', '#71b9e8', '#e6ecf3', '#ec4f4f'],
});