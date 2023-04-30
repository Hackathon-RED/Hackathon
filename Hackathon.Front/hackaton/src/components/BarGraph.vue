<template>
    <Bar
    id="my-chart-id"
    :options="chartOptions"
    :data="chartData"
    />
</template>

<script>
  import { Bar } from 'vue-chartjs'
  import { Chart as ChartJS, Title, Tooltip, Legend, BarElement, CategoryScale, LinearScale } from 'chart.js'
  
  ChartJS.register(Title, Tooltip, Legend, BarElement, CategoryScale, LinearScale)
  
  export default {
    name: 'BarChart',
    components: { Bar },
    data() {
      return {
        chartData: {
          
          labels: [ 'Janeiro', 'Fevereiro', 'Março', 'Abril', 'Maio', 'Junho', 'Julho', 'Agosto', 'Setembro', 'Outubro', 'Novembro', 'Dezembro'  ],
          datasets: [{
            label: 'Adoções do Ano de 2023',
            backgroundColor: '#005438',
            data: [30, 24, 12, 37]
          }]
        },
        chartOptions: {
          responsive: true
        }
      }
    }
  }
  </script>