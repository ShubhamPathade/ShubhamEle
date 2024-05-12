new Chartist.Bar('.barHorizontal', {
  labels: ['Q1', 'Q2', 'Q3', 'Q4'],
  series: [
    [
      {meta: 'Likes', value: 6},
      {meta: 'Likes', value: 5},
      {meta: 'Likes', value: 4},
      {meta: 'Likes', value: 3},
    ],
    [
      {meta: 'Comments', value: 5},
      {meta: 'Comments', value: 4},
      {meta: 'Comments', value: 3},
      {meta: 'Comments', value: 2},
    ],
    [
      {meta: 'Shares', value: 4},
      {meta: 'Shares', value: 3},
      {meta: 'Shares', value: 2},
      {meta: 'Shares', value: 1},
    ],
  ],
}, {
  seriesBarDistance: 11,
  reverseData: true,
  horizontalBars: true,
  height: "200px",
  chartPadding: {
    right: 0,
    left: 0,
    top: 0,
    bottom: -10,
  },
  axisY: {
    offset: 30
  },
  plugins: [
    Chartist.plugins.tooltip()
  ], 
});
