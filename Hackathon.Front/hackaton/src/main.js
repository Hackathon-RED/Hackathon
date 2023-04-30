import { createApp } from 'vue' 
import App from './App.vue'
import router from './router.js'
import { RouterView } from 'vue-router'

const app = createApp(App) 

app.use(RouterView)
app.use(router)
app.mount('#app')