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
      <ul>
        <li>
          <router-link to="/">Dashboard</router-link>
        </li>
        <li>
          <router-link to="/profile">Perfil</router-link>
        </li>
        <li>
          <router-link to="/profile">Adoções</router-link>
        </li>
        <li>
          <router-link to="/cadastro-vet">Veterinários</router-link>
        </li>
      </ul>
    </div>
    <div style="width: 100%; height: 100%;">
      <router-view></router-view>  
    </div>
  </div>
</template>

<style scoped>

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
</style>
