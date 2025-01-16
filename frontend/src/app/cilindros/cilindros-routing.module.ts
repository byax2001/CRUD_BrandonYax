import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LayoutPageComponent } from './pages/layout-page/layout-page.component';
import { CreateCilindroComponent } from './pages/create-cilindro/create-cilindro.component';
import { EditCilindroComponent } from './pages/edit-cilindro/edit-cilindro.component';
import { TablesCilindrosComponent } from './pages/tables-cilindros/tables-cilindros.component';



// localhost:4200/heroes
const routes: Routes = [
  {
    path: '',
    component: LayoutPageComponent,
    children: [
      { path: 'cilindrosC', component: CreateCilindroComponent},
      { path: 'edit/:id', component: EditCilindroComponent},
      { path: 'cilindros', component: TablesCilindrosComponent},
      { path: '**', redirectTo: 'cilindrosC' },
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CilindrosRoutingModule { }
