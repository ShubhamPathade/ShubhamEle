// Displaying X Labels Diagonally (Bar Chart)
var day_data = [
	{"period": "2016-10-01", "licensed": 4, "Milestone Admin": 2},
	{"period": "2016-09-30", "licensed": 5, "Milestone Admin": 1},
	{"period": "2016-09-29", "licensed": 8, "Milestone Admin": 4},
	{"period": "2016-09-20", "licensed": 2, "Milestone Admin": 2},
	{"period": "2016-09-19", "licensed": 7, "Milestone Admin": 6},
	{"period": "2016-09-18", "licensed": 4, "Milestone Admin": 3},
	{"period": "2016-09-17", "licensed": 7, "Milestone Admin": 7},
	{"period": "2016-09-16", "licensed": 8, "Milestone Admin": 2},
	{"period": "2016-09-15", "licensed": 9, "Milestone Admin": 3},
	{"period": "2016-09-10", "licensed": 2, "Milestone Admin": 9}
];
Morris.Bar({
	element: 'xLabelsDiagonally',
	data: day_data,
	xkey: 'period',
	ykeys: ['licensed', 'Milestone Admin'],
	labels: ['Licensed', 'Milestone Admin'],
	xLabelAngle: 60,
	gridLineColor: "#e4e6f2",
	resize: true,
	hideHover: "auto",
	barColors:['#3888f3', '#2f99de', '#3c9fe0', '#49a6e2', '#56ace4', '#63b3e6', '#71b9e8', '#e6ecf3', '#ec4f4f'],
});