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
          <router-link to="/"><i class="fa-solid fa-table-columns icon-dash"></i>Dashboard</router-link>
        </li>
        <li>
          <router-link to="/perfil"> <i class="fa-solid fa-user icon-dash"></i>Perfil</router-link>
        </li>
        <li>
          <router-link to="/adocao"><i class="fa-solid fa-hand-holding-heart icon-dash"/>Adoções</router-link>
        </li>
        <li>
          <router-link to="/cadastro-vet"><i class="fa fa-user-md icon-dash"/>Veterinários</router-link>
        </li>
        <!-- <li>
          <router-link to="/cadastro-ong"><i class="fa-solid fa-building-ngo"></i>ONGs</router-link>
        </li> -->
        <li>
          <router-link to="/cadastro-pet"><i class="fa fa-paw icon-dash"/>Pets</router-link>
        </li>
        <!-- <li>
          <router-link to="/cadastro-user"><i class="fa fa-user icon-dash"/>Usuários</router-link>
        </li> -->
      </ul>
    </div>
    <div style="width: 100%; height: 100%;">
      <router-view></router-view>  
    </div>
  </div>
</template>

<style scoped>

#icon-donate{

}

 .icon-doacao{
  width: 20px;
  padding-right: 1rem;
  filter: invert(1);
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
</style>
