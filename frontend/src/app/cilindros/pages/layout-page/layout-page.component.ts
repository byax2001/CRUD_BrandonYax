import { Component } from '@angular/core';

@Component({
  selector: 'layout-page',
  standalone: false,

  templateUrl: './layout-page.component.html',
  styleUrl: './layout-page.component.css'
})
export class LayoutPageComponent {

  public sidebarItems = [
    { label: 'Crear Cilindro', icon: 'add', url: '/cil/cilindrosC' },
    { label: 'Listado', icon: 'label', url: '/cil/cilindros' }
  ]
}
