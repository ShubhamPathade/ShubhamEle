var chart10 = c3.generate({
	bindto: '#donutChart',
	data: {
		columns: [
			['Likes', 12],
			['Shares', 87],
			['Clicks', 51],
		],
		type : 'donut',
		colors: {
			Likes: '#49a6e2',
			Shares: '#2f99de',
			Clicks: '#3888f3',
		},
	},
	donut: {
		title: "Clicks"
	},
});