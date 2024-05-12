Morris.Donut({
	element: 'donutFormatter',
	data: [
		{value: 155, label: 'voo', formatted: 'at least 70%' },
		{value: 12, label: 'bar', formatted: 'approx. 15%' },
		{value: 10, label: 'baz', formatted: 'approx. 10%' },
		{value: 5, label: 'A really really long label', formatted: 'at most 5%' }
	],
	resize: true,
	hideHover: "auto",
	formatter: function (x, data) { return data.formatted; },
	colors:['#3888f3', '#2f99de', '#3c9fe0', '#49a6e2', '#56ace4', '#63b3e6', '#71b9e8', '#e6ecf3', '#ec4f4f']
});