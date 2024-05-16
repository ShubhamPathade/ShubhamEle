// Animated
$(function() {
	var updatingChart = $(".updating-chart-one").peity("line", {
		width: 150,
		height: 36,
		stroke: "#3888f3",
		fill: false,
		strokeWidth: 2,
	});
	setInterval(function() {
		var random = Math.round(Math.random() * 10)
		var values = updatingChart.text().split(",")
		values.shift()
		values.push(random)

		updatingChart
		.text(values.join(","))
		.change()
	}, 1000)
})
$(function() {
	var updatingChart = $(".updating-chart-two").peity("line", {
		width: 150,
		height: 36,
		stroke: "#fc6d4c",
		fill: false,
		strokeWidth: 2,
	});
	setInterval(function() {
		var random = Math.round(Math.random() * 10)
		var values = updatingChart.text().split(",")
		values.shift()
		values.push(random)

		updatingChart
		.text(values.join(","))
		.change()
	}, 1000)
})
$(function() {
	var updatingChart = $(".updating-chart-three").peity("line", {
		width: 150,
		height: 36,
		stroke: "#0063bf",
		fill: false,
		strokeWidth: 2,
	});
	setInterval(function() {
		var random = Math.round(Math.random() * 10)
		var values = updatingChart.text().split(",")
		values.shift()
		values.push(random)
		updatingChart
		.text(values.join(","))
		.change()
	}, 1000)
})
$(function() {
	var updatingChart = $(".updating-chart-four").peity("line", {
		width: 150,
		height: 36,
		stroke: "#3ecfac",
		fill: false,
		strokeWidth: 2,
	});
	setInterval(function() {
		var random = Math.round(Math.random() * 10)
		var values = updatingChart.text().split(",")
		values.shift()
		values.push(random)

		updatingChart
		.text(values.join(","))
		.change()
	}, 1000)
})





// Line Chart
$(function() {
	var updatingChart = $(".line-one").peity("line", {
		width: 150,
		height: 36,
		stroke: "#3888f3",
		fill: false,
		strokeWidth: 3,
	});
})
$(function() {
	var updatingChart = $(".line-two").peity("line", {
		width: 150,
		height: 36,
		stroke: "#fc6d4c",
		fill: false,
		strokeWidth: 3,
	});
})
$(function() {
	var updatingChart = $(".line-three").peity("line", {
		width: 150,
		height: 36,
		stroke: "#3ecfac",
		fill: false,
		strokeWidth: 3,
	});
})





// Bar Chart
$(function(){
	$(".bar-one").peity("bar", {
		width: 90,
		height: 40,
		fill: ["#1d6bf1"],
	})
});
$(function(){
	$(".bar-two").peity("bar", {
		width: 90,
		height: 40,
		fill: ["#fe6235"],
	})
});
$(function(){
	$(".bar-three").peity("bar", {
		width: 90,
		height: 40,
		fill: function(_, i, all) {
			var g = parseInt((i / all.length) * 255)
			return "rgb(15, " + g + ", 220)"
		}
	})
});
