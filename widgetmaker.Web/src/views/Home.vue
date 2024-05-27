<template>
  <div class="home">
    <v-container style="max-width: 900px">
      <v-card>
        <v-card-title class="d-flex">
          Welcome to the Widget Maker
        </v-card-title>
        <v-divider></v-divider>
        <v-card-text>
          <p>
            Use the <a href="/widget">Widgets</a> page to define the types of Widgets we can make
          </p>
          <p>Use <a href="/admin/Widget">Manage Widgets</a> to manage widgets we can make </p>
          <v-form ref="form">
            lets make some widgets
            <h2 class="py-2">
              Make Widgets <c-display :model="widgetMaker" for="widgetId" />
            </h2>
          </v-form>
        </v-card-text>
      </v-card>
    </v-container>
  </div>
</template>

<script setup lang="ts">
useTitle("Home");
</script>
