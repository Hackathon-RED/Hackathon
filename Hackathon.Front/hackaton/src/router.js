import { createRouter, createWebHistory } from 'vue-router'
import CadastroUsuario from './components/views/CadastroUsuario.vue'
import CadastroPet from './components/views/CadastroPet.vue'
import CadastroOng from './components/views/CadastroOng.vue'
import CadastroVer from './components/views/CadastroVet.vue'
import Adocoes from './components/views/Adocoes.vue'
import Dashboard from './components/views/Dashboard.vue'
import Perfil from './components/views/Perfil.vue'
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