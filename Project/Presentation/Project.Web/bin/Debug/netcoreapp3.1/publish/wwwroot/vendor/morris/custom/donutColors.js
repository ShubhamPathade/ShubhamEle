// Morris Donut
Morris.Donut({
	element: 'donutColors',
	data: [
		{value: 70, label: 'foo'},
		{value: 15, label: 'bar'},
		{value: 10, label: 'baz'},
		{value: 5, label: 'A really really long label'}
	],
	backgroundColor: '#ffffff',
	labelColor: '#666666',
	colors:['#3888f3', '#2f99de', '#3c9fe0', '#49a6e2', '#56ace4', '#63b3e6', '#71b9e8', '#e6ecf3', '#ec4f4f'],
	resize: true,
	hideHover: "auto",
	gridLineColor: "#e4e6f2",
	formatter: function (x) { return x + "%"}
});