import { createRouter, createWebHistory } from 'vue-router'
import CadastroUsuario from './../src/components/views/CadastroUsuario.vue'
import CadastroPet from './../src/components/views/CadastroPet.vue'
import CadastroOng from './../src/components/views/CadastroOng.vue'
import CadastroVer from './../src/components/views/CadastroVet.vue'
import Adocoes from './../src/components/views/Adocoes.vue'
import Dashboard from './../src/components/views/Dashboard.vue'
import Perfil from './../src/components/views/Perfil.vue'
import 'font-awesome/css/font-awesome.css'

const routes = [
  {
    path: '/',
    name: 'Dashboard',
    component: Dashboard
  },
  {
    path: '/perfil',
    name: 'perfil',
    component: Perfil
  },
  {
    path: '/cadastro-ong',
    name: '/cadastro-ong',
    component: CadastroOng
  },
  {
    path: '/adocao',
    name: 'adocao',
    component: Adocoes
  },
  {
    path: '/cadastro-vet',
    name: 'cadastro-vet',
    component: CadastroVer
  },
  {
    path: '/cadastro-pet',
    name: 'cadastro-pet',
    component: CadastroPet
  },
  {
    path: '/cadastro-user',
    name: 'cadastro-user',
    component: CadastroUsuario
  }
]

const router = createRouter({
  history: createWebHistory(),
  routes
})

export default router