<?php

use yii\helpers\Html;
use yii\widgets\DetailView;

/* @var $this yii\web\View */
/* @var $model common\models\Bilet */

$this->title = $model->nazwa;
$this->params['breadcrumbs'][] = ['label' => 'Bilety', 'url' => ['index']];
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="bilet-view">

    <h1><?= Html::encode($this->title) ?></h1>

    <p>
        <?= Html::a('Zmień', ['update', 'id' => $model->id], ['class' => 'btn btn-primary']) ?>
        <?= Html::a('Usuń', ['delete', 'id' => $model->id], [
            'class' => 'btn btn-danger',
            'data' => [
                'confirm' => 'Czy na pewno chcesz usunąć ten element?',
                'method' => 'post',
            ],
        ]) ?>
    </p>

    <?= DetailView::widget([
        'model' => $model,
        'attributes' => [
            // 'id',
            'klasa',
            'numer_miejsca',
            'cena:currency',
            'imie',
            'nazwisko',
            'lot.nazwa:text:Lot',
            'zakup.nazwa:text:Zakup',
        ],
    ]) ?>

</div>
