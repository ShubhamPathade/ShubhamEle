// Morris Days
var day_data = [
	{"period": "2016-10-01", "licensed": 3213, "Milestone Admin": 887},
	{"period": "2016-09-30", "licensed": 3321, "Milestone Admin": 776},
	{"period": "2016-09-29", "licensed": 3671, "Milestone Admin": 884},
	{"period": "2016-09-20", "licensed": 3176, "Milestone Admin": 448},
	{"period": "2016-09-19", "licensed": 3376, "Milestone Admin": 565},
	{"period": "2016-09-18", "licensed": 3976, "Milestone Admin": 627},
	{"period": "2016-09-17", "licensed": 2239, "Milestone Admin": 660},
	{"period": "2016-09-16", "licensed": 3871, "Milestone Admin": 676},
	{"period": "2016-09-15", "licensed": 3659, "Milestone Admin": 656},
	{"period": "2016-09-10", "licensed": 3380, "Milestone Admin": 663}
];
Morris.Line({
	element: 'dayData',
	data: day_data,
	xkey: 'period',
	ykeys: ['licensed', 'Milestone Admin'],
	labels: ['Licensed', 'Milestone Admin'],
	resize: true,
	hideHover: "auto",
	gridLineColor: "#e4e6f2",
	pointFillColors:['#ffffff'],
	pointStrokeColors: ['#ff5661'],
	lineColors:['#3888f3', '#2f99de', '#3c9fe0', '#49a6e2', '#56ace4', '#63b3e6', '#71b9e8', '#e6ecf3', '#ec4f4f'],
});