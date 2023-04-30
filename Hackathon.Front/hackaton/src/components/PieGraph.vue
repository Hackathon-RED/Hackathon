<template>
    <Pie
    id="pie-chart"
    :options="chartOptions"
    :data="chartData"
    />
</template>

<script>
  import { Pie } from 'vue-chartjs'
  import { Chart as ChartJS, ArcElement, Tooltip, Legend } from 'chart.js'
  
  ChartJS.register(ArcElement, Tooltip, Legend)
  
  export default {
    name: 'PieChart',
    components: { Pie },
    data() {
      return {
        chartData: {
          labels: [ 'Adotados', 'Não Adeptos', 'Aguardando' ],
          datasets: [
                {
                backgroundColor: ['#054f77', '#900603', '#FFD881'],
                data: [90, 37, 294]
                }
            ]
        },
        chartOptions: {
          responsive: true,
          maintainAspectRatio: false
        }
      }
    }
  }
  </script>