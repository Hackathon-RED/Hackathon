<template>
    <div>
      <input type="date" v-bind="$attrs" :value="value" @input="$emit('input', $event.target.value)">
    </div>
</template>

<script>
export default {
  name: "DateForm",
  props: {
    value: {
      type: String,
      default: ""
    }
  }
};
</script>
