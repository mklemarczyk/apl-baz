<?php

use yii\helpers\Html;

/* @var $this yii\web\View */
/* @var $model common\models\Klient */

$this->title = 'Update Klient: ' . ' ' . $model->id;
$this->params['breadcrumbs'][] = ['label' => 'Klients', 'url' => ['index']];
$this->params['breadcrumbs'][] = ['label' => $model->id, 'url' => ['view', 'id' => $model->id]];
$this->params['breadcrumbs'][] = 'Update';
?>
<div class="klient-update">

    <h1><?= Html::encode($this->title) ?></h1>

    <?= $this->render('_form', [
        'model' => $model,
    ]) ?>

</div>
