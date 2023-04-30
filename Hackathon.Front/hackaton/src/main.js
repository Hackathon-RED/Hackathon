import { createApp } from 'vue' 
import App from './App.vue'
import router from './router.js'
import { RouterView } from 'vue-router'
import { library } from '@fortawesome/fontawesome-svg-core'
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome'
import { fas } from '@fortawesome/free-solid-svg-icons'
import '@fortawesome/fontawesome-free/css/fontawesome.css';
import '@fortawesome/fontawesome-free/css/brands.css';
import '@fortawesome/fontawesome-free/css/solid.css';
import '@fortawesome/fontawesome-free/css/all.css';


const app = createApp(App) 

library.add(fas)
app.use(library)
app.component('font-awesome-icon', FontAwesomeIcon)

app.use(RouterView)
app.use(router)
app.mount('#app')