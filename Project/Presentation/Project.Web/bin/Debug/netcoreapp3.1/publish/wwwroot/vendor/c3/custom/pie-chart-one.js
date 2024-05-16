var chart12 = c3.generate({
	bindto: '#pieChart1',
	data: {
		// iris data from R
		columns: [
			['Mon', 179],
			['Tue', 147],
			['Wed', 110],
			['Thu', 87],
			['Fri', 60],
			['Sat', 30],
		],
		type : 'pie',
		colors: {
			Mon: '#3888f3',
			Tue: '#2f99de',
			Wed: '#3c9fe0',
			Thu: '#49a6e2',
			Fri: '#56ace4',
			Sat: '#63b3e6',
		},
	},
});