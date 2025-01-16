import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path:'cil',
    loadChildren: ()=> import('./cilindros/cilindros.module').then(m => m.CilindrosModule),
  },
  {
    path: '',
    redirectTo: 'cil',
    pathMatch: 'full'
  },
  {
    path: '**',
    redirectTo: 'cilindroC',
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
