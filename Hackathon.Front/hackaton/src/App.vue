<script setup>
import CadastroPet from './components/views/CadastroPet.vue'
import CadastroUsuario from './components/views/CadastroUsuario.vue'
import CadastroOng from './components/views/CadastroOng.vue'
import CadastroVet from './components/views/CadastroVet.vue'
import ListaAdocao from './components/views/ListaAdocao.vue'
import { RouterView } from 'vue-router'
import 'font-awesome/css/font-awesome.css'


</script>

<template>
  <div id="nav">
    <div class="menu">
      <ul style="height: 97vh;">
        <li class="logo">
          <div style="width: 150px;">
              <svg xmlns="http://www.w3.org/2000/svg" version="1.0" preserveAspectRatio="xMidYMid meet" viewBox="125.19 187.11 249.63 89.89">
                <g transform="translate(0.000000,500.000000) scale(0.100000,-0.100000)" fill="#000000" stroke="none">
                <path fill="white" d="M3384 3115 c-4 -10 11 -34 39 -64 72 -77 85 -168 36 -268 -37 -77 -163 -130 -248 -105 -20 6 -80 42 -133 80 -54 39 -117 75 -144 83 -63 18 -190 16 -277 -5 -78 -18 -217 -21 -300 -6 -38 8 -65 20 -87 40 -51 47 -131 72 -235 74 -123 1 -180 -26 -257 -122 l-54 -67 -99 -5 c-55 -3 -108 -9 -117 -14 -9 -4 -24 -24 -33 -43 -37 -78 -1 -230 75 -316 l32 -37 -155 0 c-123 0 -157 -3 -167 -15 -27 -32 -1 -35 304 -35 l302 0 22 -30 23 -30 234 0 234 0 34 30 35 30 143 0 c140 0 144 -1 183 -27 l39 -28 260 -3 c270 -3 287 -1 287 39 0 18 11 19 190 19 166 0 191 2 197 16 3 9 0 20 -8 25 -8 5 -100 9 -205 9 l-191 0 -13 25 c-18 34 -66 63 -117 71 l-42 6 6 62 c5 61 5 61 -24 72 l-30 11 5 -43 c2 -23 1 -55 -2 -69 -7 -27 -8 -27 -84 -25 -98 3 -102 3 -102 -14 0 -24 15 -27 152 -36 90 -6 138 -14 155 -25 22 -15 63 -71 63 -87 0 -5 -106 -8 -235 -8 -194 0 -241 3 -266 15 -64 34 -89 128 -50 191 19 32 74 64 109 64 27 0 37 17 21 36 -17 21 -72 11 -122 -22 -53 -35 -81 -99 -74 -171 l6 -53 -113 0 -113 0 5 29 c2 18 -6 51 -21 84 -21 47 -32 58 -80 81 l-55 27 21 50 c19 44 20 55 9 106 -6 31 -10 58 -8 61 3 2 33 -1 68 -6 68 -11 194 -2 269 18 61 17 206 18 252 2 21 -8 74 -41 119 -74 135 -100 188 -115 298 -82 39 12 66 29 105 67 110 111 113 260 7 379 -45 49 -68 59 -78 33z m-1252 -230 c99 -13 168 -99 168 -209 0 -54 -3 -61 -35 -92 -46 -43 -101 -59 -132 -39 -21 14 -23 23 -25 138 -3 114 -4 122 -23 122 -19 0 -20 -8 -23 -127 -3 -127 -3 -127 25 -158 24 -27 36 -32 73 -32 25 0 58 5 73 11 37 14 83 14 110 0 41 -21 77 -62 83 -95 7 -37 -18 -99 -47 -115 -11 -5 -107 -8 -236 -7 l-218 3 0 35 c0 30 5 37 40 57 35 20 54 23 151 23 90 0 114 3 125 16 11 14 10 18 -6 31 -16 12 -43 14 -125 11 -93 -4 -112 -8 -160 -34 -29 -16 -61 -41 -69 -56 -15 -26 -21 -28 -80 -28 l-65 0 31 33 c17 17 35 41 41 52 7 14 21 20 44 20 26 0 33 4 33 20 0 16 -13 23 -63 37 -35 9 -70 14 -78 11 -20 -8 -17 -31 6 -43 19 -10 19 -13 5 -41 -20 -38 -73 -64 -111 -55 -40 10 -89 67 -113 131 -27 71 -26 75 5 75 14 0 34 5 45 10 24 14 52 67 46 90 -4 15 4 18 54 22 66 5 90 21 139 97 36 57 72 79 147 90 57 8 70 8 165 -4z"/>
                <path fill="white" d="M1836 2731 c-20 -32 52 -101 105 -101 30 0 79 35 79 56 0 22 -29 28 -49 10 -32 -29 -91 -10 -91 30 0 15 -35 19 -44 5z"/>
                </g>
            </svg>
          </div>
        </li>
        <li>
          <router-link to="/">Dashboard</router-link>
        </li>
        <li>
          <router-link to="/perfil">Perfil</router-link>
        </li>
        <li>
          <router-link to="/adocao"><img class="icon-doacao" src="./assets/adocao.svg"/>Adoções</router-link>
        </li>
        <li>
          <router-link to="/cadastro-vet"><i class="fa fa-user-md icon-dash"/>Veterinários</router-link>
        </li>
        <li>
          <router-link to="/cadastro-ong"><i class="fa fa-user-md icon-dash"/>ONGs</router-link>
        </li>
        <li>
          <router-link to="/cadastro-pet"><i class="fa fa-paw icon-dash"/>Pets</router-link>
        </li>
        <li>
          <router-link to="/cadastro-user"><i class="fa fa-user icon-dash"/>Usuários</router-link>
        </li>
      </ul>
    </div>
    <div style="width: 100%; height: 100%;">
      <router-view></router-view>  
    </div>
  </div>
</template>

<style scoped>
 .icon-doacao{
  width: 20px;

 }

.icon-dash{
  padding-right: 1rem;
}

#nav {
  display: flex;
}

.menu ul {
  margin-right: 1rem;
  padding: 15px;
  background-color: #005438;
  width: 250px;
  border-radius: 0 15px 15px 0;
  margin: 0;
}
.menu ul li {
  cursor: pointer;
  list-style: none;
  padding: 5px 10px;
  border-radius: 5px;
  transition: 0.25s ease-in-out;
  margin: 10px 0;
}

.menu ul li:hover {
  background-color: white;
}

.menu ul li:hover a {
  color: #005438;
}

.menu ul li a {
  text-decoration: none;
  font-weight: bold;
  font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
  color: white;
}

.logo {
  display: flex; 
  justify-content: center;
  transition: 0;
}

.menu ul .logo:hover {
  background-color: #005438;
}

.menu ul .logo:hover a {
  color: white;
}
</style>
