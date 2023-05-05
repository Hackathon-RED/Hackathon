<template>
    <div>
      <input type="text" v-bind="$attrs" :value="value" @input="$emit('input', $event.target.value)">
    </div>
</template>

<script>
export default {
  name: "InputForm",
  props: {
    value: {
      type: String,
      default: ""
    }
  }
};
</script>
